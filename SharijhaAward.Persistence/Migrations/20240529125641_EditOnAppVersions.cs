using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditOnAppVersions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppleLink",
                table: "AppVersions");

            migrationBuilder.RenameColumn(
                name: "GooglePlayLink",
                table: "AppVersions",
                newName: "AppLink");

            migrationBuilder.AddColumn<int>(
                name: "AppType",
                table: "AppVersions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2130), new DateTime(2024, 6, 8, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2136), new DateTime(2024, 6, 3, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2149), new DateTime(2024, 6, 13, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2152), new DateTime(2024, 6, 8, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2155), new DateTime(2024, 6, 18, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2157), new DateTime(2024, 6, 13, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2160), new DateTime(2024, 6, 23, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2161), new DateTime(2024, 6, 18, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2164), new DateTime(2024, 6, 28, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2166), new DateTime(2024, 6, 23, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2781), new DateTime(2024, 5, 29, 15, 56, 36, 733, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2806), new DateTime(2024, 5, 29, 15, 56, 36, 733, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2811), new DateTime(2024, 5, 29, 15, 56, 36, 733, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2815), new DateTime(2024, 5, 29, 15, 56, 36, 733, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(4287), new DateTime(2024, 6, 3, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(4292), new DateTime(2024, 5, 31, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(4302), new DateTime(2024, 6, 1, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(4306), new DateTime(2024, 6, 6, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(4309), new DateTime(2024, 6, 3, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(4310), new DateTime(2024, 6, 4, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(5564), new DateTime(2024, 6, 8, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(5571), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(5776), new DateTime(2024, 6, 18, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(5779), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 731, DateTimeKind.Utc).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 29, 12, 56, 36, 733, DateTimeKind.Utc).AddTicks(2581));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppType",
                table: "AppVersions");

            migrationBuilder.RenameColumn(
                name: "AppLink",
                table: "AppVersions",
                newName: "GooglePlayLink");

            migrationBuilder.AddColumn<string>(
                name: "AppleLink",
                table: "AppVersions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3516), new DateTime(2024, 6, 6, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3519), new DateTime(2024, 6, 1, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3524), new DateTime(2024, 6, 11, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3526), new DateTime(2024, 6, 6, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3528), new DateTime(2024, 6, 16, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3529), new DateTime(2024, 6, 11, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3532), new DateTime(2024, 6, 21, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3534), new DateTime(2024, 6, 16, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3536), new DateTime(2024, 6, 26, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3537), new DateTime(2024, 6, 21, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3817), new DateTime(2024, 5, 27, 11, 49, 43, 620, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3841), new DateTime(2024, 5, 27, 11, 49, 43, 620, DateTimeKind.Local).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3843), new DateTime(2024, 5, 27, 11, 49, 43, 620, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3845), new DateTime(2024, 5, 27, 11, 49, 43, 620, DateTimeKind.Local).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5772), new DateTime(2024, 6, 1, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5775), new DateTime(2024, 5, 29, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5782), new DateTime(2024, 5, 30, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5784), new DateTime(2024, 6, 4, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5786), new DateTime(2024, 6, 1, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5787), new DateTime(2024, 6, 2, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6195), new DateTime(2024, 6, 6, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6199), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6334), new DateTime(2024, 6, 16, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6335), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3699));
        }
    }
}
