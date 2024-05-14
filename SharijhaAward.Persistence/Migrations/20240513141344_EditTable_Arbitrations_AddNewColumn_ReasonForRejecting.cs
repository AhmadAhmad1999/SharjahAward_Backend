using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_Arbitrations_AddNewColumn_ReasonForRejecting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ReasonForRejecting",
                table: "Arbitrations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7572), new DateTime(2024, 5, 23, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7585), new DateTime(2024, 5, 18, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7599) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7605), new DateTime(2024, 5, 28, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7609), new DateTime(2024, 5, 23, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7615), new DateTime(2024, 6, 2, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7619), new DateTime(2024, 5, 28, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7625), new DateTime(2024, 6, 7, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7628), new DateTime(2024, 6, 2, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7634), new DateTime(2024, 6, 12, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7638), new DateTime(2024, 6, 7, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7642) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1259));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2941), 5000 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2951), 5000 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2958), 5000 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2964), 5000 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2971), 5000 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2977), 5000 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2984), 5000 });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2839), 5000 });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2847), 5000 });

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8558), new DateTime(2024, 5, 13, 17, 13, 39, 972, DateTimeKind.Local).AddTicks(8568) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8689), new DateTime(2024, 5, 13, 17, 13, 39, 972, DateTimeKind.Local).AddTicks(8693) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8702), new DateTime(2024, 5, 13, 17, 13, 39, 972, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8714), new DateTime(2024, 5, 13, 17, 13, 39, 972, DateTimeKind.Local).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8402), new DateTime(2024, 5, 18, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8410), new DateTime(2024, 5, 15, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8425), new DateTime(2024, 5, 16, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8433), new DateTime(2024, 5, 21, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8438), new DateTime(2024, 5, 18, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8441), new DateTime(2024, 5, 19, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(9954), new DateTime(2024, 5, 23, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(9964) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 13, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(357), new DateTime(2024, 6, 2, 14, 13, 39, 970, DateTimeKind.Utc).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 969, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 973, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7833));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 14, 13, 39, 972, DateTimeKind.Utc).AddTicks(8170));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReasonForRejecting",
                table: "Arbitrations");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(663), new DateTime(2024, 5, 23, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(677), new DateTime(2024, 5, 18, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(701), new DateTime(2024, 5, 28, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(705), new DateTime(2024, 5, 23, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(713), new DateTime(2024, 6, 2, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(719), new DateTime(2024, 5, 28, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(726), new DateTime(2024, 6, 7, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(732), new DateTime(2024, 6, 2, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 6, 12, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(744), new DateTime(2024, 6, 7, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5901), null });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5913), null });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5918), null });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5924), null });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5930), null });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5936), null });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5941), null });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5777), 0 });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "SizeOfAttachmentInKB" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5783), 0 });

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2170), new DateTime(2024, 5, 13, 11, 24, 56, 267, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2316), new DateTime(2024, 5, 13, 11, 24, 56, 267, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2331), new DateTime(2024, 5, 13, 11, 24, 56, 267, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2362), new DateTime(2024, 5, 13, 11, 24, 56, 267, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4381), new DateTime(2024, 5, 18, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4390), new DateTime(2024, 5, 15, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4410), new DateTime(2024, 5, 16, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4419), new DateTime(2024, 5, 21, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4424), new DateTime(2024, 5, 18, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4428), new DateTime(2024, 5, 19, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(5929), new DateTime(2024, 5, 23, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(6423), new DateTime(2024, 6, 2, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1679));
        }
    }
}
