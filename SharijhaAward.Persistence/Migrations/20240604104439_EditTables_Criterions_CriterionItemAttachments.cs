using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTables_Criterions_CriterionItemAttachments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MaxAttachmentNumber",
                table: "Criterions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxAttachmentNumber",
                table: "CriterionItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(711), new DateTime(2024, 6, 14, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(722), new DateTime(2024, 6, 9, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(745), new DateTime(2024, 6, 19, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(748), new DateTime(2024, 6, 14, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(754), new DateTime(2024, 6, 24, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(757), new DateTime(2024, 6, 19, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(762), new DateTime(2024, 6, 29, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(768), new DateTime(2024, 6, 24, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(773), new DateTime(2024, 7, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(775), new DateTime(2024, 6, 29, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "MaxAttachmentNumber" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6796), 0 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "MaxAttachmentNumber" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6804), 0 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "MaxAttachmentNumber" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6809), 0 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "MaxAttachmentNumber" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6814), 0 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "MaxAttachmentNumber" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6819), 0 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "MaxAttachmentNumber" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6826), 0 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "MaxAttachmentNumber" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6831), 0 });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "MaxAttachmentNumber" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6675), null });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "MaxAttachmentNumber" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6682), null });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "MaxAttachmentNumber" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6687), null });

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1608), new DateTime(2024, 6, 4, 13, 44, 33, 826, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1750), new DateTime(2024, 6, 4, 13, 44, 33, 826, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1778), new DateTime(2024, 6, 4, 13, 44, 33, 826, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1789), new DateTime(2024, 6, 4, 13, 44, 33, 826, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4355), new DateTime(2024, 6, 9, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4360), new DateTime(2024, 6, 6, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4378), new DateTime(2024, 6, 7, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4383), new DateTime(2024, 6, 12, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4386), new DateTime(2024, 6, 9, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4388), new DateTime(2024, 6, 10, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(5481), new DateTime(2024, 6, 14, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(5487) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(5924), new DateTime(2024, 6, 24, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1278));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxAttachmentNumber",
                table: "Criterions");

            migrationBuilder.DropColumn(
                name: "MaxAttachmentNumber",
                table: "CriterionItems");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5935), new DateTime(2024, 6, 14, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5943), new DateTime(2024, 6, 9, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5962), new DateTime(2024, 6, 19, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5964), new DateTime(2024, 6, 14, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5967), new DateTime(2024, 6, 24, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5969), new DateTime(2024, 6, 19, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5972), new DateTime(2024, 6, 29, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5975), new DateTime(2024, 6, 24, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5978), new DateTime(2024, 7, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5980), new DateTime(2024, 6, 29, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6695), new DateTime(2024, 6, 4, 12, 13, 21, 685, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6812), new DateTime(2024, 6, 4, 12, 13, 21, 685, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6838), new DateTime(2024, 6, 4, 12, 13, 21, 685, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6853), new DateTime(2024, 6, 4, 12, 13, 21, 685, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2410), new DateTime(2024, 6, 9, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2415), new DateTime(2024, 6, 6, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2432), new DateTime(2024, 6, 7, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2437), new DateTime(2024, 6, 12, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2440), new DateTime(2024, 6, 9, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2442), new DateTime(2024, 6, 10, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3368), new DateTime(2024, 6, 14, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3659), new DateTime(2024, 6, 24, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6418));
        }
    }
}
