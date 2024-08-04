using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addSeedToDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6752), new DateTime(2024, 8, 10, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6778), new DateTime(2024, 8, 14, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6772), new DateTime(2024, 8, 9, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6764) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6780), new DateTime(2024, 8, 16, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6784), new DateTime(2024, 8, 20, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6782), new DateTime(2024, 8, 15, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6787), new DateTime(2024, 8, 22, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6795), new DateTime(2024, 8, 26, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6792), new DateTime(2024, 8, 21, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6797), new DateTime(2024, 8, 28, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6802), new DateTime(2024, 9, 1, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6799), new DateTime(2024, 8, 27, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6805), new DateTime(2024, 9, 3, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6809), new DateTime(2024, 9, 7, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6807), new DateTime(2024, 9, 2, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(6808) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9124));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(2046), new DateTime(2024, 8, 9, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 8, 6, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(2064), new DateTime(2024, 8, 7, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(2067), new DateTime(2024, 8, 12, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(2069), new DateTime(2024, 8, 9, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(2071), new DateTime(2024, 8, 10, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(634));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3188));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(2815), new DateTime(2024, 8, 14, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(2819), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3045), new DateTime(2024, 8, 24, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(3048), "Saturday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8914));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9692));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9695));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1219), "تصدير معرض الصور", 2 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Action", "CreatedAt", "Name" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1222), "إضافة نسخة التطبيق" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1225), "عرض نسخة التطبيق", 3 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1228), "تصدير نسخة التطبيق", 3 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Action", "CreatedAt", "Name" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1231), "إضافة إصدارات الجائزة" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Action", "CreatedAt", "Name" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1234), "عرض إصدارات الجائزة" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1250), "تعديل إصدارات الجائزة", 4 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1253), "حذف إصدارات الجائزة", 4 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1256), "تصدير إصدارات الجائزة", 4 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1259), "تعديل راعي الجائزة", 5 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Action", "CreatedAt", "Name" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1262), "إضافة التعاميم" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1265), "عرض التعاميم", 6 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1267), "تعديل التعاميم", 6 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1270), "حذف التعاميم", 6 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1273), "تصدير التعاميم", 6 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1276), "إضافة الصفوف", 7 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1279), "عرض الصفوف", 7 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1282), "تعديل الصفوف", 7 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1285), "حذف الصفوف", 7 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1288), "تصدير الصفوف", 7 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1290), "إضافة محكم صف", 8 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1294), "عرض محكم صف", 8 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1297), "حذف محكم صف", 8 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1299), "تصدير محكم صف", 8 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1302), "عرض الدورات", 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1305), "إضافة دورة", 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1308), "عرض معلومات دورة", 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1311), "تعديل دورة", 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1314), "حذف دورة", 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1317), "تصدير دورة", 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1319), "إضافة أجندة", 10 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1323), "عرض أجندة", 10 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1325), "تعديل أجندة", 10 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1328), "حذف أجندة", 10 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1331), "تصدير أجندة", 2 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1334), "إضافة فئات", 11 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1337), "عرض فئات", 11 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1340), "تعديل فئات", 11 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1342), "حذف فئات", 11 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1345), "تصدير فئات", 11 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1348), "إضافة شروط عامة", 12 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1352), "عرض شروط عامة", 12 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1354), "تعديل شروط عامة", 12 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1357), "حذف شروط عامة", 12 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1360), "تصدير شروط عامة", 12 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1363), "إضافة جهات تعليمية", 13 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1366), "عرض جهات تعليمية", 13 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1368), "تعديل جهات تعليمية", 13 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1371), "حذف جهات تعليمية", 13 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1374), "تصدير معرض الصور", 13 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1377), "عرض ملفات النظام", 14 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "download", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1379), "تحميل ملفات النظام", 14 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1382), "إضافة ورش تدريبية عامة", 15 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1385), "عرض ورش تدريبية عامة", 15 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1389), "تعديل ورش تدريبية عامة", 15 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1392), "حذف ورش تدريبية عامة", 15 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1395), "تصدير معرض الصور", 15 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1397), "عرض التعليمات", 16 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1400), "تعديل التعليمات", 16 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1403), "تصدير التعليمات", 16 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1406), "إضافة الإجتماعات", 17 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1409), "عرض الإجتماعات", 17 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1412), "تعديل الإجتماعات", 17 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1415), "حذف الإجتماعات", 17 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1418), "تصدير الإجتماعات", 17 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "send_emails", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1421), "إرسال بريد إلكتروني للإجتماعات", 17 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "cancel", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1423), "إلغاء الإجتماعات", 17 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1426), "إضافة الأخبار", 18 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1429), "عرض الأخبار", 18 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1432), "تعديل الأخبار", 18 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1435), "حذف الأخبار", 18 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1438), "تصدير الأخبار", 18 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1441), "إضافة الإشعارات", 19 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1444), "عرض الإشعارات", 19 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1446), "تعديل الإشعارات", 19 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1450), "حذف الإشعارات", 19 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1453), "تصدير الإشعارات", 19 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1455), "إضافة قالب الإشعارات", 20 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1458), "عرض قالب الإشعارات", 20 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1470), "تعديل قالب الإشعارات", 20 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1473), "حذف قالب الإشعارات", 20 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1476), "تصدير قالب الإشعارات", 20 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1479), "إضافة دور", 21 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1482), "عرض دور", 21 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1484), "تعديل دور", 21 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1487), "حذف دور", 21 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1490), "تصدير دور", 21 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1493), "إضافة مستخدم", 22 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1496), "عرض مستخدم", 22 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1499), "تعديل مستخدم", 22 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1502), "حذف مستخدم", 22 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1504), "تصدير مستخدم", 22 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "user_change_password", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1507), "تغيير كلمة سر المستخدم", 22 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1510), "إضافة منسق", 23 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1512), "عرض منسق", 23 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1516), "تعديل منسق", 23 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1519), "حذف منسق", 23 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1522), "تصدير منسق", 23 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "coordinator_dynamic_fields", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1525), "حقول ديناميكية للمنسقين", 23 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1528), "إضافة محكم", 24 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1531), "عرض محكم", 24 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1533), "تعديل محكم", 24 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1537), "حذف محكم", 24 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1539), "تصدير محكم", 24 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "arbitrator_dynamic_fields", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1543), "حقول ديناميكية للمحكمين", 24 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1545), "إضافة لجنة", 25 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1548), "عرض لجنة", 25 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1551), "تعديل لجنة", 25 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1554), "حذف لجنة", 25 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1558), "تصدير لجنة", 25 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1560), "إضافة حساب المشترك", 26 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1563), "عرض حساب المشترك", 26 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1566), "تعديل حساب المشترك", 26 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1569), "حذف حساب المشترك", 26 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1572), "تصدير حساب المشترك", 26 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "subscriber_change_password", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1575), "تغيير كلمة سر المشترك", 26 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "verify_account", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1578), "تأكيد الحساب", 26 });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Action", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "PermissionHeaderId", "isDeleted" },
                values: new object[,]
                {
                    { 123, "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1580), null, null, null, null, "عرض ملف المشترك", 27, false },
                    { 124, "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1583), null, null, null, null, "تصدير ملف المشترك", 27, false },
                    { 125, "read_as_subscriber", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1586), null, null, null, null, "قراءة كمشترك", 27, false },
                    { 126, "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1589), null, null, null, null, "عرض إستمارة المشترك", 28, false },
                    { 127, "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1592), null, null, null, null, "حذف إستمارة المشترك", 28, false },
                    { 128, "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1595), null, null, null, null, "تصدير إستمارة المشترك", 28, false },
                    { 129, "reject", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1598), null, null, null, null, "رفض إستمارة", 28, false },
                    { 130, "accept", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1601), null, null, null, null, "قبول إستمارة", 28, false },
                    { 131, "information", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1604), null, null, null, null, "معلومات الإستمارة", 28, false },
                    { 132, "conditions", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1607), null, null, null, null, "شروط الإستمارة", 28, false },
                    { 133, "attachments", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1610), null, null, null, null, "شروط الإستمارة", 28, false },
                    { 134, "criteria", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1612), null, null, null, null, "معايير الإستمارة", 28, false },
                    { 135, "award_team", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1615), null, null, null, null, "فريق الجائزة الإستمارة", 28, false },
                    { 136, "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1618), null, null, null, null, "إضافة فعالية", 29, false },
                    { 137, "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1621), null, null, null, null, "عرض فعالية", 29, false },
                    { 138, "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1624), null, null, null, null, "تعديل فعالية", 29, false },
                    { 139, "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1626), null, null, null, null, "حذف فعالية", 29, false },
                    { 140, "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1629), null, null, null, null, "تصدير فعالية", 29, false },
                    { 141, "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1632), null, null, null, null, "عرض رسالة تواصل", 30, false },
                    { 142, "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1634), null, null, null, null, "حذف رسالة تواصل", 30, false },
                    { 143, "xlsx-exportable", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1637), null, null, null, null, "تصدير رسالة تواصل", 30, false },
                    { 144, "forward_message", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1640), null, null, null, null, "تحويل الرسالة", 30, false },
                    { 145, "close_message", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1643), null, null, null, null, "إغلاق الرسالة", 30, false },
                    { 146, "replay", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1645), null, null, null, null, "الرد على الرسالة", 30, false },
                    { 147, "read_replies", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1648), null, null, null, null, "قراءة الرد", 30, false },
                    { 148, "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1651), null, null, null, null, "عرض رسالة توضيحية", 31, false },
                    { 149, "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1653), null, null, null, null, "تعديل رسالة توضيحية", 31, false },
                    { 150, "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1656), null, null, null, null, "إضافة مسؤولية", 32, false },
                    { 151, "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1659), null, null, null, null, "عرض مسؤولية", 32, false },
                    { 152, "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1661), null, null, null, null, "تعديل مسؤولية", 32, false },
                    { 153, "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1664), null, null, null, null, "حذف مسؤولية", 32, false },
                    { 154, "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1667), null, null, null, null, "إضافة الأسئلة الشائعة العامة", 33, false },
                    { 155, "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1669), null, null, null, null, "عرض الأسئلة الشائعة العامة", 33, false },
                    { 156, "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1672), null, null, null, null, "تعديل الأسئلة الشائعة العامة", 33, false },
                    { 157, "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1675), null, null, null, null, "حذف الأسئلة الشائعة العامة", 33, false },
                    { 158, "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1677), null, null, null, null, "إضافة فئة الأسئلة الشائعة", 34, false },
                    { 159, "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1690), null, null, null, null, "عرض فئة الأسئلة الشائعة", 34, false },
                    { 160, "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1693), null, null, null, null, "تعديل فئة الأسئلة الشائعة", 34, false },
                    { 161, "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1696), null, null, null, null, "حذف فئة الأسئلة الشائعة", 34, false },
                    { 162, "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1699), null, null, null, null, "إضافة إحصائيات الجائزة", 35, false },
                    { 163, "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1701), null, null, null, null, "عرض إحصائيات الجائزة", 35, false },
                    { 164, "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1704), null, null, null, null, "تعديل إحصائيات الجائزة", 35, false },
                    { 165, "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1707), null, null, null, null, "حذف إحصائيات الجائزة", 35, false },
                    { 166, "create", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1709), null, null, null, null, "إضافة شرائح", 36, false },
                    { 167, "read", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1712), null, null, null, null, "عرض شرائح", 36, false },
                    { 168, "update", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1715), null, null, null, null, "تعديل شرائح", 36, false },
                    { 169, "delete", new DateTime(2024, 8, 4, 13, 7, 31, 327, DateTimeKind.Utc).AddTicks(1717), null, null, null, null, "حذف شرائح", 36, false }
                });

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 329, DateTimeKind.Utc).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 4, 13, 7, 31, 328, DateTimeKind.Utc).AddTicks(7218));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4616), new DateTime(2024, 8, 7, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4630), new DateTime(2024, 8, 11, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4629), new DateTime(2024, 8, 6, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4631), new DateTime(2024, 8, 13, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4634), new DateTime(2024, 8, 17, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4633), new DateTime(2024, 8, 12, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4635), new DateTime(2024, 8, 19, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4639), new DateTime(2024, 8, 23, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4637), new DateTime(2024, 8, 18, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4640), new DateTime(2024, 8, 25, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4643), new DateTime(2024, 8, 29, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4641), new DateTime(2024, 8, 24, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4642) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4644), new DateTime(2024, 8, 31, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4647), new DateTime(2024, 9, 4, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4645), new DateTime(2024, 8, 30, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4783));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5494));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5292));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6327), new DateTime(2024, 8, 6, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6330), new DateTime(2024, 8, 3, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6339), new DateTime(2024, 8, 4, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6341), new DateTime(2024, 8, 9, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6343), new DateTime(2024, 8, 6, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6344), new DateTime(2024, 8, 7, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6910), new DateTime(2024, 8, 11, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6914), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7074), new DateTime(2024, 8, 21, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(7076), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5824));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5842));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5889));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5955), "إضافة نسخة التطبيق", 3 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Action", "CreatedAt", "Name" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5958), "عرض نسخة التطبيق" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5961), "إضافة إصدارات الجائزة", 4 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5963), "عرض إصدارات الجائزة", 4 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Action", "CreatedAt", "Name" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5965), "تعديل إصدارات الجائزة" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Action", "CreatedAt", "Name" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5967), "حذف إصدارات الجائزة" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5969), "تعديل راعي الجائزة", 5 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5971), "إضافة التعاميم", 6 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5973), "عرض التعاميم", 6 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5975), "تعديل التعاميم", 6 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Action", "CreatedAt", "Name" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5978), "حذف التعاميم" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5980), "إضافة الصفوف", 7 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5983), "عرض الصفوف", 7 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5985), "تعديل الصفوف", 7 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5988), "حذف الصفوف", 7 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5990), "إضافة محكم صف", 8 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5992), "عرض محكم صف", 8 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5994), "حذف محكم صف", 8 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5997), "عرض الدورات", 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(5999), "إضافة دورة", 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6001), "عرض معلومات دورة", 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6002), "تعديل دورة", 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6004), "حذف دورة", 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6006), "إضافة أجندة", 10 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6008), "عرض أجندة", 10 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6010), "تعديل أجندة", 10 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6012), "حذف أجندة", 10 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6014), "إضافة فئات", 11 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6016), "عرض فئات", 11 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6018), "تعديل فئات", 11 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6020), "حذف فئات", 11 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6022), "إضافة شروط عامة", 12 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6024), "عرض شروط عامة", 12 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6026), "تعديل شروط عامة", 12 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6028), "حذف شروط عامة", 12 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6030), "إضافة جهات تعليمية", 13 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6031), "عرض جهات تعليمية", 13 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6033), "تعديل جهات تعليمية", 13 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6035), "حذف جهات تعليمية", 13 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6037), "عرض ملفات النظام", 14 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6039), "إضافة ورش تدريبية عامة", 15 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6041), "عرض ورش تدريبية عامة", 15 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6043), "تعديل ورش تدريبية عامة", 15 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6045), "حذف ورش تدريبية عامة", 15 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6046), "عرض التعليمات", 16 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6048), "تعديل التعليمات", 16 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6050), "إضافة الإجتماعات", 17 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6052), "عرض الإجتماعات", 17 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6054), "تعديل الإجتماعات", 17 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6056), "حذف الإجتماعات", 17 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6058), "إضافة الأخبار", 18 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6060), "عرض الأخبار", 18 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6061), "تعديل الأخبار", 18 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6063), "حذف الأخبار", 18 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6065), "إضافة الإشعارات", 19 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6067), "عرض الإشعارات", 19 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6069), "تعديل الإشعارات", 19 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6071), "حذف الإشعارات", 19 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6073), "إضافة قالب الإشعارات", 20 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6075), "عرض قالب الإشعارات", 20 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6077), "تعديل قالب الإشعارات", 20 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6078), "حذف قالب الإشعارات", 20 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6080), "إضافة دور", 21 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6082), "عرض دور", 21 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6084), "تعديل دور", 21 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6086), "حذف دور", 21 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6088), "إضافة مستخدم", 22 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6090), "عرض مستخدم", 22 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6092), "تعديل مستخدم", 22 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6094), "حذف مستخدم", 22 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6096), "إضافة منسق", 23 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6098), "عرض منسق", 23 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6100), "تعديل منسق", 23 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6101), "حذف منسق", 23 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6111), "إضافة محكم", 24 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6113), "عرض محكم", 24 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6114), "تعديل محكم", 24 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6116), "حذف محكم", 24 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6118), "إضافة لجنة", 25 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6120), "عرض لجنة", 25 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6122), "تعديل لجنة", 25 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6124), "حذف لجنة", 25 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6126), "إضافة حساب المشترك", 26 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6128), "عرض حساب المشترك", 26 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6130), "تعديل حساب المشترك", 26 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6132), "حذف حساب المشترك", 26 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6133), "عرض ملف المشترك", 27 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6135), "عرض إستمارة المشترك", 28 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6137), "حذف إستمارة المشترك", 28 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6139), "إضافة فعالية", 29 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6141), "عرض فعالية", 29 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6143), "تعديل فعالية", 29 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6145), "حذف فعالية", 29 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6146), "عرض رسالة تواصل", 30 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6148), "حذف رسالة تواصل", 30 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6150), "عرض رسالة توضيحية", 31 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6153), "تعديل رسالة توضيحية", 31 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6155), "إضافة مسؤولية", 32 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6157), "عرض مسؤولية", 32 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6159), "تعديل مسؤولية", 32 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6161), "حذف مسؤولية", 32 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6163), "إضافة الأسئلة الشائعة العامة", 33 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6165), "عرض الأسئلة الشائعة العامة", 33 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6167), "تعديل الأسئلة الشائعة العامة", 33 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6169), "حذف الأسئلة الشائعة العامة", 33 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6171), "إضافة فئة الأسئلة الشائعة", 34 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6172), "عرض فئة الأسئلة الشائعة", 34 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6175), "تعديل فئة الأسئلة الشائعة", 34 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6176), "حذف فئة الأسئلة الشائعة", 34 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6178), "إضافة إحصائيات الجائزة", 35 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6180), "عرض إحصائيات الجائزة", 35 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6182), "تعديل إحصائيات الجائزة", 35 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6184), "حذف إحصائيات الجائزة", 35 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "create", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6186), "إضافة شرائح", 36 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "read", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6188), "عرض شرائح", 36 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "update", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6189), "تعديل شرائح", 36 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "Action", "CreatedAt", "Name", "PermissionHeaderId" },
                values: new object[] { "delete", new DateTime(2024, 8, 1, 10, 7, 32, 988, DateTimeKind.Utc).AddTicks(6191), "حذف شرائح", 36 });

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 1, 10, 7, 32, 989, DateTimeKind.Utc).AddTicks(4842));
        }
    }
}
