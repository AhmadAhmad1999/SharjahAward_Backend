using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addArabicNameToPermissionHeader : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PermissionHeaders",
                newName: "EnglishName");

            migrationBuilder.AddColumn<string>(
                name: "ArabicName",
                table: "PermissionHeaders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6663), new DateTime(2024, 8, 5, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6679), new DateTime(2024, 8, 9, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6678), new DateTime(2024, 8, 4, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6681), new DateTime(2024, 8, 11, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6685), new DateTime(2024, 8, 15, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6683), new DateTime(2024, 8, 10, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6686), new DateTime(2024, 8, 17, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6690), new DateTime(2024, 8, 21, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6688), new DateTime(2024, 8, 16, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6689) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6692), new DateTime(2024, 8, 23, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6695), new DateTime(2024, 8, 27, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6693), new DateTime(2024, 8, 22, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6694) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6696), new DateTime(2024, 8, 29, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6699), new DateTime(2024, 9, 2, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6698), new DateTime(2024, 8, 28, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6699) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4915));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9653));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9182));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9406));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3991), new DateTime(2024, 8, 4, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3994), new DateTime(2024, 8, 1, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4004), new DateTime(2024, 8, 2, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4008), new DateTime(2024, 8, 7, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4010), new DateTime(2024, 8, 4, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4011), new DateTime(2024, 8, 5, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9288));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4851));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4542), new DateTime(2024, 8, 9, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4545), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4739), new DateTime(2024, 8, 19, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(4741), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "حول الجائزة", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "الألبوم", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "نسخة التطبيق", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8083) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "إصدارات الجائزة", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8085) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "راعي الجائزة", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8087) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "التعاميم", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "الصفوف", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "صفوف المحكمين", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "الدورات", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8095) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "الاجندة", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "الفئات", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8099) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "حول الجائزة", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "الجهات التعليمية", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8103) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "ملفات النظام", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "الدورات التدريبية العامة", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8106) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "التعليمات", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8109) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "الإجتماعات", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8111) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "الأخبار", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8112) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "الإشعارات", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "قالب الإشعارات", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "الدور", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "المستخدمين", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "المنسقين", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8124) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "المحكمين", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "اللجان", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8138) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "حسابات المشتركين", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "الملف الشخصي للمشتركين", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "نموذج الإشتراك", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8144) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "الفعاليات", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "تواصل معنا", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8148) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "الرسائل التوضيحية", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "المسؤوليات", new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(8152) });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 736, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9722));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 30, 10, 58, 1, 737, DateTimeKind.Utc).AddTicks(7015));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArabicName",
                table: "PermissionHeaders");

            migrationBuilder.RenameColumn(
                name: "EnglishName",
                table: "PermissionHeaders",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9510), new DateTime(2024, 8, 4, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9520), new DateTime(2024, 8, 8, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9519), new DateTime(2024, 8, 3, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9522), new DateTime(2024, 8, 10, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9526), new DateTime(2024, 8, 14, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9524), new DateTime(2024, 8, 9, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9525) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9527), new DateTime(2024, 8, 16, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9530), new DateTime(2024, 8, 20, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9529), new DateTime(2024, 8, 15, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9529) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9532), new DateTime(2024, 8, 22, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9535), new DateTime(2024, 8, 26, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9534), new DateTime(2024, 8, 21, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9535) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9537), new DateTime(2024, 8, 28, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9540), new DateTime(2024, 9, 1, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9538), new DateTime(2024, 8, 27, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2138));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9631), new DateTime(2024, 8, 3, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9636), new DateTime(2024, 7, 31, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9646), new DateTime(2024, 8, 1, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9647) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9648), new DateTime(2024, 8, 6, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9650), new DateTime(2024, 8, 3, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9651), new DateTime(2024, 8, 4, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9652) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2240));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(130), new DateTime(2024, 8, 8, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(134), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(280), new DateTime(2024, 8, 18, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(282), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9421));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9453));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9476));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9501));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 115, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 117, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 29, 14, 10, 34, 116, DateTimeKind.Utc).AddTicks(9776));
        }
    }
}
