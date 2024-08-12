using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddIsReadtoCircular : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "Circulars",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5946), new DateTime(2024, 8, 17, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5960), new DateTime(2024, 8, 21, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5959), new DateTime(2024, 8, 16, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5961), new DateTime(2024, 8, 23, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5964), new DateTime(2024, 8, 27, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5963), new DateTime(2024, 8, 22, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5965), new DateTime(2024, 8, 29, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5972), new DateTime(2024, 9, 2, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5970), new DateTime(2024, 8, 28, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5973), new DateTime(2024, 9, 4, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5976), new DateTime(2024, 9, 8, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5974), new DateTime(2024, 9, 3, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5977), new DateTime(2024, 9, 10, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5980), new DateTime(2024, 9, 14, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5978), new DateTime(2024, 9, 9, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(5979) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8238));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5605), new DateTime(2024, 8, 16, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5607), new DateTime(2024, 8, 13, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5616), new DateTime(2024, 8, 14, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5617) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5619), new DateTime(2024, 8, 19, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5621), new DateTime(2024, 8, 16, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5622), new DateTime(2024, 8, 17, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5623) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6070), new DateTime(2024, 8, 21, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6073), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6216), new DateTime(2024, 8, 31, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(6219), "Saturday" });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7092));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5241));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5286));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5387));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 707, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 11, 10, 30, 53, 708, DateTimeKind.Utc).AddTicks(6231));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "Circulars");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(24), new DateTime(2024, 8, 13, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(36), new DateTime(2024, 8, 17, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(34), new DateTime(2024, 8, 12, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(29) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(38), new DateTime(2024, 8, 19, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(41), new DateTime(2024, 8, 23, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(39), new DateTime(2024, 8, 18, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(40) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(42), new DateTime(2024, 8, 25, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(44), new DateTime(2024, 8, 29, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(43), new DateTime(2024, 8, 24, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(44) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(45), new DateTime(2024, 8, 31, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(48), new DateTime(2024, 9, 4, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(47), new DateTime(2024, 8, 30, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(47) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(49), new DateTime(2024, 9, 6, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(52), new DateTime(2024, 9, 10, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(50), new DateTime(2024, 9, 5, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(51) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5418), new DateTime(2024, 8, 12, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5422), new DateTime(2024, 8, 9, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5430), new DateTime(2024, 8, 10, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5432) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5434), new DateTime(2024, 8, 15, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5436), new DateTime(2024, 8, 12, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5437), new DateTime(2024, 8, 13, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2145));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2154));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5809), new DateTime(2024, 8, 17, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5815), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5864), new DateTime(2024, 8, 27, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5866), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5270));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 314, DateTimeKind.Utc).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 7, 13, 28, 32, 315, DateTimeKind.Utc).AddTicks(198));
        }
    }
}
