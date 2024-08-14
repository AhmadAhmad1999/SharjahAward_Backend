using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_Interviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Interviews",
                newName: "StartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Interviews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2413), new DateTime(2024, 8, 20, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2424), new DateTime(2024, 8, 24, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2422), new DateTime(2024, 8, 19, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2426), new DateTime(2024, 8, 26, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2429), new DateTime(2024, 8, 30, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2427), new DateTime(2024, 8, 25, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2430), new DateTime(2024, 9, 1, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2433), new DateTime(2024, 9, 5, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2432), new DateTime(2024, 8, 31, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2441), new DateTime(2024, 9, 7, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2444), new DateTime(2024, 9, 11, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2442), new DateTime(2024, 9, 6, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2445), new DateTime(2024, 9, 13, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2447), new DateTime(2024, 9, 17, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2446), new DateTime(2024, 9, 12, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3751));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3104));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3128));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7382), new DateTime(2024, 8, 19, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7387), new DateTime(2024, 8, 16, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7394), new DateTime(2024, 8, 17, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7395) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7396), new DateTime(2024, 8, 22, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7397), new DateTime(2024, 8, 19, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7398), new DateTime(2024, 8, 20, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7399) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7749), new DateTime(2024, 8, 24, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7753) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7864), new DateTime(2024, 9, 3, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3373));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3198));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3221));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3230));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3237));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 324, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 14, 25, 54, 325, DateTimeKind.Utc).AddTicks(2589));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Interviews");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Interviews",
                newName: "Date");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2678), new DateTime(2024, 8, 20, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2688), new DateTime(2024, 8, 24, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2686), new DateTime(2024, 8, 19, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2683) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2690), new DateTime(2024, 8, 26, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2693), new DateTime(2024, 8, 30, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2691), new DateTime(2024, 8, 25, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2692) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2694), new DateTime(2024, 9, 1, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2697), new DateTime(2024, 9, 5, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2695), new DateTime(2024, 8, 31, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2696) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2698), new DateTime(2024, 9, 7, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2701), new DateTime(2024, 9, 11, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2699), new DateTime(2024, 9, 6, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2702), new DateTime(2024, 9, 13, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2705), new DateTime(2024, 9, 17, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2703), new DateTime(2024, 9, 12, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2704) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4791));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3514));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7112), new DateTime(2024, 8, 19, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7117), new DateTime(2024, 8, 16, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7129), new DateTime(2024, 8, 17, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7132), new DateTime(2024, 8, 22, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7133), new DateTime(2024, 8, 19, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7134), new DateTime(2024, 8, 20, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7517), new DateTime(2024, 8, 24, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7522) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7651), new DateTime(2024, 9, 3, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(7654) });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3855));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3872));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4323));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3617));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3673));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 191,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 192,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 193,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 187, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 14, 13, 42, 38, 188, DateTimeKind.Utc).AddTicks(2900));
        }
    }
}
