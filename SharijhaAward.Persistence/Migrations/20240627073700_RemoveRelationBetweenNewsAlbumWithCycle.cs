using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRelationBetweenNewsAlbumWithCycle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Cycles_CycleId",
                table: "Albums");

            migrationBuilder.DropForeignKey(
                name: "FK_News_Cycles_CycleId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_CycleId",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_Albums_CycleId",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "CycleId",
                table: "News");

            migrationBuilder.DropColumn(
                name: "CycleId",
                table: "Albums");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "PageStructures",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EnglishTitle",
                table: "PageStructures",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6041), new DateTime(2024, 7, 3, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6049), new DateTime(2024, 7, 7, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6048), new DateTime(2024, 7, 2, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6050), new DateTime(2024, 7, 9, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6053), new DateTime(2024, 7, 13, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6051), new DateTime(2024, 7, 8, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6054), new DateTime(2024, 7, 15, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6057), new DateTime(2024, 7, 19, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6055), new DateTime(2024, 7, 14, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6058), new DateTime(2024, 7, 21, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6062), new DateTime(2024, 7, 25, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6060), new DateTime(2024, 7, 20, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6063), new DateTime(2024, 7, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6066), new DateTime(2024, 7, 31, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6064), new DateTime(2024, 7, 26, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6447), new DateTime(2024, 6, 27, 10, 36, 56, 930, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6474), new DateTime(2024, 6, 27, 10, 36, 56, 930, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6476), new DateTime(2024, 6, 27, 10, 36, 56, 930, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6478), new DateTime(2024, 6, 27, 10, 36, 56, 930, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7280), new DateTime(2024, 7, 2, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7283), new DateTime(2024, 6, 29, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7290), new DateTime(2024, 6, 30, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7292), new DateTime(2024, 7, 5, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7294), new DateTime(2024, 7, 2, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7295), new DateTime(2024, 7, 3, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7813), new DateTime(2024, 7, 7, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7817), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7951), new DateTime(2024, 7, 17, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7953), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.CreateIndex(
                name: "IX_PageStructures_EnglishTitle",
                table: "PageStructures",
                column: "EnglishTitle",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PageStructures_Slug",
                table: "PageStructures",
                column: "Slug",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PageStructures_EnglishTitle",
                table: "PageStructures");

            migrationBuilder.DropIndex(
                name: "IX_PageStructures_Slug",
                table: "PageStructures");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "PageStructures",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "EnglishTitle",
                table: "PageStructures",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "CycleId",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CycleId",
                table: "Albums",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3799), new DateTime(2024, 7, 2, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3807), new DateTime(2024, 7, 6, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3806), new DateTime(2024, 7, 1, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3803) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3808), new DateTime(2024, 7, 8, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3811), new DateTime(2024, 7, 12, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3809), new DateTime(2024, 7, 7, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3810) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3812), new DateTime(2024, 7, 14, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3815), new DateTime(2024, 7, 18, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3814), new DateTime(2024, 7, 13, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3816), new DateTime(2024, 7, 20, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3819), new DateTime(2024, 7, 24, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3818), new DateTime(2024, 7, 19, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3821), new DateTime(2024, 7, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3823), new DateTime(2024, 7, 30, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3822), new DateTime(2024, 7, 25, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5166));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5236));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6099));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6102));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4886));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4188), new DateTime(2024, 6, 26, 15, 46, 4, 355, DateTimeKind.Local).AddTicks(4197) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4216), new DateTime(2024, 6, 26, 15, 46, 4, 355, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4218), new DateTime(2024, 6, 26, 15, 46, 4, 355, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4220), new DateTime(2024, 6, 26, 15, 46, 4, 355, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4300), new DateTime(2024, 7, 1, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4304), new DateTime(2024, 6, 28, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4310), new DateTime(2024, 6, 29, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4313), new DateTime(2024, 7, 4, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4315), new DateTime(2024, 7, 1, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4317), new DateTime(2024, 7, 2, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4317) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5920));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4792), new DateTime(2024, 7, 6, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4796), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4955), new DateTime(2024, 7, 16, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(4957), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4267));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5101));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5149));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5777), 1 });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5780), 1 });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5783), 1 });

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4987));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3748));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3822));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3826));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 354, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 26, 12, 46, 4, 355, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.CreateIndex(
                name: "IX_News_CycleId",
                table: "News",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_CycleId",
                table: "Albums",
                column: "CycleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Cycles_CycleId",
                table: "Albums",
                column: "CycleId",
                principalTable: "Cycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_News_Cycles_CycleId",
                table: "News",
                column: "CycleId",
                principalTable: "Cycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
