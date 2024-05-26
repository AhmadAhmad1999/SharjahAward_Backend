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
                name: "isAcceptedFromChairman",
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
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(975), new DateTime(2024, 6, 5, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(985), new DateTime(2024, 5, 31, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1014), new DateTime(2024, 6, 10, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1018), new DateTime(2024, 6, 5, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1025), new DateTime(2024, 6, 15, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1029), new DateTime(2024, 6, 10, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1036), new DateTime(2024, 6, 20, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1040), new DateTime(2024, 6, 15, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1047), new DateTime(2024, 6, 25, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1051), new DateTime(2024, 6, 20, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2508), new DateTime(2024, 5, 26, 15, 7, 57, 408, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2694), new DateTime(2024, 5, 26, 15, 7, 57, 408, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2737), new DateTime(2024, 5, 26, 15, 7, 57, 408, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2754), new DateTime(2024, 5, 26, 15, 7, 57, 408, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2002), new DateTime(2024, 5, 31, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2010), new DateTime(2024, 5, 28, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2032), new DateTime(2024, 5, 29, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2041), new DateTime(2024, 6, 3, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2047), new DateTime(2024, 5, 31, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2051), new DateTime(2024, 6, 1, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(3776), new DateTime(2024, 6, 5, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(3787) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4179), new DateTime(2024, 6, 15, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2043));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "isAcceptedFromChairman",
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
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1330), new DateTime(2024, 6, 5, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1341), new DateTime(2024, 5, 31, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1357), new DateTime(2024, 6, 10, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1360), new DateTime(2024, 6, 5, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1364), new DateTime(2024, 6, 15, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1366), new DateTime(2024, 6, 10, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1370), new DateTime(2024, 6, 20, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1372), new DateTime(2024, 6, 15, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1375), new DateTime(2024, 6, 25, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1379), new DateTime(2024, 6, 20, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2169), new DateTime(2024, 5, 26, 14, 0, 12, 677, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2302), new DateTime(2024, 5, 26, 14, 0, 12, 677, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2322), new DateTime(2024, 5, 26, 14, 0, 12, 677, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2330), new DateTime(2024, 5, 26, 14, 0, 12, 677, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(325), new DateTime(2024, 5, 31, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(332), new DateTime(2024, 5, 28, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(349), new DateTime(2024, 5, 29, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(354), new DateTime(2024, 6, 3, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(357), new DateTime(2024, 5, 31, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(359), new DateTime(2024, 6, 1, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1313), new DateTime(2024, 6, 5, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1569), new DateTime(2024, 6, 15, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4139));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4207));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 674, DateTimeKind.Utc).AddTicks(9882));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 674, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 674, DateTimeKind.Utc).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 674, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 674, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1840));
        }
    }
}
