using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editeOnForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArabicUpbringingAndAiographySecound",
                table: "AwardSponsors");

            migrationBuilder.DropColumn(
                name: "EnglishUpbringingAndAiographySecound",
                table: "AwardSponsors");

            migrationBuilder.RenameColumn(
                name: "EnglishUpbringingAndAiographyFirst",
                table: "AwardSponsors",
                newName: "EnglishUpbringingAndAiography");

            migrationBuilder.RenameColumn(
                name: "ArabicUpbringingAndAiographyFirst",
                table: "AwardSponsors",
                newName: "ArabicUpbringingAndAiography");

            migrationBuilder.AddColumn<string>(
                name: "ReasonForRejection",
                table: "ProvidedForms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5696), new DateTime(2024, 5, 29, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5702), new DateTime(2024, 5, 24, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5707) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5709), new DateTime(2024, 6, 3, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5711), new DateTime(2024, 5, 29, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5713) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5714), new DateTime(2024, 6, 8, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5716), new DateTime(2024, 6, 3, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5717) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5719), new DateTime(2024, 6, 13, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5721), new DateTime(2024, 6, 8, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5724), new DateTime(2024, 6, 18, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5726), new DateTime(2024, 6, 13, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5996));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7252));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6267), new DateTime(2024, 5, 19, 12, 29, 18, 806, DateTimeKind.Local).AddTicks(6272) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6290), new DateTime(2024, 5, 19, 12, 29, 18, 806, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6293), new DateTime(2024, 5, 19, 12, 29, 18, 806, DateTimeKind.Local).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6297), new DateTime(2024, 5, 19, 12, 29, 18, 806, DateTimeKind.Local).AddTicks(6298) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6817));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(4844), new DateTime(2024, 5, 24, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(4847), new DateTime(2024, 5, 21, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(4856), new DateTime(2024, 5, 22, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(4858) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(4860), new DateTime(2024, 5, 27, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(4863), new DateTime(2024, 5, 24, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(4864), new DateTime(2024, 5, 25, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8506));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5421), new DateTime(2024, 5, 29, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5428), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5611), new DateTime(2024, 6, 8, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(5613), "Saturday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7312));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7380));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7410));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 805, DateTimeKind.Utc).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ReasonForRejection" },
                values: new object[] { new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(7009), null });

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 9, 29, 18, 806, DateTimeKind.Utc).AddTicks(6055));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReasonForRejection",
                table: "ProvidedForms");

            migrationBuilder.RenameColumn(
                name: "EnglishUpbringingAndAiography",
                table: "AwardSponsors",
                newName: "EnglishUpbringingAndAiographyFirst");

            migrationBuilder.RenameColumn(
                name: "ArabicUpbringingAndAiography",
                table: "AwardSponsors",
                newName: "ArabicUpbringingAndAiographyFirst");

            migrationBuilder.AddColumn<string>(
                name: "ArabicUpbringingAndAiographySecound",
                table: "AwardSponsors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnglishUpbringingAndAiographySecound",
                table: "AwardSponsors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4689), new DateTime(2024, 5, 26, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4701), new DateTime(2024, 5, 21, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4713) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4717), new DateTime(2024, 5, 31, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4720), new DateTime(2024, 5, 26, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4722) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4724), new DateTime(2024, 6, 5, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4726), new DateTime(2024, 5, 31, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4728) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4730), new DateTime(2024, 6, 10, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4732), new DateTime(2024, 6, 5, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4734) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4736), new DateTime(2024, 6, 15, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4739), new DateTime(2024, 6, 10, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArabicUpbringingAndAiographySecound", "CreatedAt", "EnglishUpbringingAndAiographySecound" },
                values: new object[] { "هو صاحب السمو الشيخ الدكتور سلطان بن محمد بن صقر بن خالد بن سلطان بن صقر بن راشد القاسمي ولد يوم الأحد في الرابع عشر من جمادى الأولى سنة 1358 هـ، الموافق الثاني من يوليو عام 1939 م بمدينة الشارقة.\r\n\r\nوالدته الشيخة مريم بنت الشيخ غانم ابن الشيخ سالم بن عبدالله بن سعيد ابن سبت بن مطر بن سلطان بن فارس بن شهوان الشامسي.\r\n\r\nله من والدته من الأشقاء أربع الشيخ خالد والشيخ صقر والشيخ عبدالعزيز والشيخ عبدالله ومن  الشقيقات اثنتان الشيخة شيخة والشيخة ناعمة .\r\n\r\nولصاحب السمو حاكم الشارقة أخوة غير أشقاء هم الشيخ راشد والشيخ حميد والشيخ علي والشيخة موزة والشيخة علياء والشيخات غاية ونورة وعائشة وعزة.\r\n\r\nتزوج سموه من الشيخة موزة بنت سالم بن محمد ابن مانع الفلاسي (جدتها الشيخة موزة بنت الشيخ غانم ابن الشيخ سالم الشامسي خالة صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي)، وقد انجبت له ابنه المرحوم الشيخ محمد الذي توفي في الثالث من أبريل عام 1999 عن عمر يناهز 24 عاماً، وابنته الشيخة عزة .\r\n\r\nكما تزوج صاحب السمو حاكم الشارقة سمو الشيخة جواهر بنت الشيخ محمد بن سلطان بن صقر القاسمي ، وأنجبت له من الأبناء الشيخ خالد (توفي في 01 يوليو2019 عن عمر ناهز الأربعين عامًا) و الشيخة بدور والشيخة نور و الشيخة حور .. .\r\n\r\nتربى سموه على الوطنية، وترعرع على حب العلم والمعرفة، وكان شغوفا جدا بتاريخ وطنه، تفرغ في بداية عمره للدراسة وانتقل بين الشارقة والكويت ومصر ليتلقى تعليمه، وقد بدأ سموه تعليمه العام في شهر سبتمبر سنة 1948 في مدرسة الإصلاح القاسمية وكان عمره آنذاك تسع سنوات وشهرين، وكان قد درس سموه قبلها القرآن لدى الشيخ فارس ابن عبد الرحمن. وفي العام 1954 انضم صاحب السمو حاكم الشارقة للمدرسة الإنجليزية الخاصة ليدرس اللغة الإنجليزية. وانتقل سموه بين الشارقة والكويت لتلقي تعليمه الإعدادي والثانوي لينتهي به المطاف في نهاية عام 1965 في القاهرة حيث بدأ الدراسة الجامعية في كلية الزراعة بجامعة القاهرة.\r\n\r\nعمل سموه مدة عامين منذ فبراير عام 1961 وإلى سبتمبر 1963 كمدرس لمادتي اللغة الانجليزية والرياضيات بالمدرسة الصناعية بالشارقة.\r\n\r\nثم تسلم رئاسة البلدية في عام 1965 . وبعد عودته إلى الشارقة بعد اتمامه دراسته الجامعية عام 1971 تسلم صاحب السمو حاكم الشارقة إدارة مكتب سمو الحاكم بإمارة الشارقة.\r\n\r\nوبعد أيام من قيام اتحاد دولة الإمارات العربية المتحدة صباح يوم الثاني من ديسمبر عام 1971، وتحديداً في اليوم التاسع من ديسمبر تم تشكيل مجلس الوزراء ونصب صاحب السمو الشيخ الدكتور سلطان القاسمي يومها وزيراً للتربية والتعليم.\r\n\r\nوفي يوم الثلاثاء التاسع من ذي الحجة، يوم عرفة سنة 1391 هـ الموافق الخامس والعشرين من يناير 1972 تسلم صاحب السمو الشيخ الدكتور سلطان بن محمد القاسمي مقاليد حكم إمارة الشارقة بعد مقتل حاكم الشارقة آنذاك الشيخ خالد بن محمد القاسمي بعد انقلاب قاده الشيخ صقر بن سلطان القاسمي ، وليكون عضواً في المجلس الأعلى لدولة الامارات العربية المتحدة، وكان عمر سموه آنذاك 32 عاماً.\r\n\r\nويعد سموه الحاكم الثامن عشر لإمارة الشارقة من حكم القواسم الذي يعود للعام 1600 ميلادية.\r\n\r\nوقد قاد سموه التنمية الثقافية والاقتصادية والاجتماعية في إمارة الشارقة، وبذل سموه جهداً اضافياً ووفر مصادر لتشجيع التفاعل والحوار الثقافي محلياً واقليمياً ودولياً بين الشعوب كافة.", new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8552), "He is His Highness Sheikh Dr. Sultan bin Muhammad bin Saqr bin Khalid bin Sultan bin Saqr bin Rashid Al Qasimi. He was born on Sunday, the fourteenth of Jumada Al-Awwal, 1358 AH, corresponding to the second of July, 1939 AD, in the city of Sharjah.\r\n\r\nHis mother is Sheikha Maryam, daughter of Sheikh Ghanem, son of Sheikh Salem bin Abdullah bin Saeed bin Sabt bin Matar bin Sultan bin Faris bin Shahwan Al Shamsi.\r\n\r\nHe has four brothers from his mother, Sheikh Khaled, Sheikh Saqr, Sheikh Abdulaziz, and Sheikh Abdullah, and two sisters, Sheikha Sheikha and Sheikha Naamah.\r\n\r\nHis Highness the Ruler of Sharjah has half-siblings, Sheikh Rashid, Sheikh Humaid, Sheikh Ali, Sheikha Moza, Sheikha Alia, and Sheikhs Ghaya, Noura, Aisha and Azza.\r\n\r\nHis Highness married Sheikha Moza bint Salem bin Mohammed bin Mani Al Falasi (her grandmother was Sheikha Moza bint Sheikh Ghanem bin Sheikh Salem Al Shamsi, aunt of His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi), and she gave birth to his son, the late Sheikh Mohammed, who died on April 3, 1999. Omar is 24 years old, and his daughter, Sheikha Azza.\r\n\r\nHis Highness the Ruler of Sharjah also married Her Highness Sheikha Jawaher, daughter of Sheikh Mohammed bin Sultan bin Saqr Al Qasimi, and she bore him children Sheikh Khaled (died on July 1, 2019 at the age of forty), Sheikha Bodour, Sheikha Nour, and Sheikha Hoor...\r\n\r\nHis Highness was raised on patriotism, and he grew up with a love of science and knowledge, and he was very passionate about the history of his homeland. At the beginning of his life, he devoted himself to studying and moved between Sharjah, Kuwait, and Egypt to receive his education. His Highness began his general education in September 1948 at Al-Islah Al-Qasimia School, and he was nine years and two months old at the time. Before that, His Highness had studied the Qur’an with Sheikh Faris bin Abdul Rahman. In 1954, His Highness the Ruler of Sharjah joined the private English school to study the English language. His Highness moved between Sharjah and Kuwait to receive his preparatory and secondary education, ending up at the end of 1965 in Cairo, where he began university studies at the Faculty of Agriculture at Cairo University.\r\n\r\nHis Highness worked for two years from February 1961 to September 1963 as a teacher of English and mathematics at the Sharjah Industrial School.\r\n\r\nThen he assumed the presidency of the municipality in 1965. After his return to Sharjah after completing his university studies in 1971, His Highness the Ruler of Sharjah assumed the management of the Office of His Highness the Ruler in the Emirate of Sharjah.\r\n\r\nDays after the establishment of the United Arab Emirates on the morning of December 2, 1971, and specifically on the ninth of December, the Council of Ministers was formed and His Highness Sheikh Dr. Sultan Al Qasimi was appointed Minister of Education that day.\r\n\r\nOn Tuesday, the ninth of Dhu al-Hijjah, the day of Arafah in the year 1391 AH, corresponding to the twenty-fifth of January 1972, His Highness Sheikh Dr. Sultan bin Muhammad Al Qasimi took over the reins of rule of the Emirate of Sharjah after the killing of the ruler of Sharjah at the time, Sheikh Khalid bin Muhammad Al Qasimi, after a coup led by Sheikh Saqr bin Sultan Al Qasimi. To be a member of the Supreme Council of the United Arab Emirates, His Highness was 32 years old at the time.\r\n\r\nHis Highness is the eighteenth ruler of the Emirate of Sharjah during the Qawasim rule, which dates back to the year 1600 AD.\r\n\r\nHis Highness led the cultural, economic and social development in the Emirate of Sharjah, and His Highness made an additional effort and provided resources to encourage cultural interaction and dialogue locally, regionally and internationally among all peoples." });

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9113));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9222));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5604), new DateTime(2024, 5, 16, 12, 21, 40, 106, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5727), new DateTime(2024, 5, 16, 12, 21, 40, 106, DateTimeKind.Local).AddTicks(5730) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5736), new DateTime(2024, 5, 16, 12, 21, 40, 106, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5744), new DateTime(2024, 5, 16, 12, 21, 40, 106, DateTimeKind.Local).AddTicks(5747) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2142), new DateTime(2024, 5, 21, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2147), new DateTime(2024, 5, 18, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2162), new DateTime(2024, 5, 19, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2202), new DateTime(2024, 5, 24, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2205), new DateTime(2024, 5, 21, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2207), new DateTime(2024, 5, 22, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9332));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9441));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9474));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3173), new DateTime(2024, 5, 26, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3180), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3451), new DateTime(2024, 6, 5, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(3455), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 104, DateTimeKind.Utc).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(298));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 107, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 16, 9, 21, 40, 106, DateTimeKind.Utc).AddTicks(5266));
        }
    }
}
