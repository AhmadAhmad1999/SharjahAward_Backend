using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddFiledNeedSignToForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "needSing",
                table: "ProvidedForms",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2265), new DateTime(2024, 8, 12, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2273), new DateTime(2024, 8, 16, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2272), new DateTime(2024, 8, 11, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2275), new DateTime(2024, 8, 18, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2278), new DateTime(2024, 8, 22, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2276), new DateTime(2024, 8, 17, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2279), new DateTime(2024, 8, 24, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2283), new DateTime(2024, 8, 28, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2281), new DateTime(2024, 8, 23, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2284), new DateTime(2024, 8, 30, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2287), new DateTime(2024, 9, 3, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2286), new DateTime(2024, 8, 29, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2288), new DateTime(2024, 9, 5, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2292), new DateTime(2024, 9, 9, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2290), new DateTime(2024, 9, 4, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4360), new DateTime(2024, 8, 11, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4363), new DateTime(2024, 8, 8, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4371), new DateTime(2024, 8, 9, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4373), new DateTime(2024, 8, 14, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4374), new DateTime(2024, 8, 11, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4376), new DateTime(2024, 8, 12, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4815), new DateTime(2024, 8, 16, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4818), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4945), new DateTime(2024, 8, 26, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4947), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2457));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "needSing",
                table: "ProvidedForms");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6917), new DateTime(2024, 8, 11, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6926), new DateTime(2024, 8, 15, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6925), new DateTime(2024, 8, 10, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6927), new DateTime(2024, 8, 17, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6930), new DateTime(2024, 8, 21, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6928), new DateTime(2024, 8, 16, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6929) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6931), new DateTime(2024, 8, 23, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6934), new DateTime(2024, 8, 27, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6933), new DateTime(2024, 8, 22, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6935), new DateTime(2024, 8, 29, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6938), new DateTime(2024, 9, 2, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6937), new DateTime(2024, 8, 28, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6939), new DateTime(2024, 9, 4, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6942), new DateTime(2024, 9, 8, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6941), new DateTime(2024, 9, 3, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9691));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9743));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9751));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7796));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7569));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8493), new DateTime(2024, 8, 10, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8496), new DateTime(2024, 8, 7, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8503), new DateTime(2024, 8, 8, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8506), new DateTime(2024, 8, 13, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8508), new DateTime(2024, 8, 10, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8509), new DateTime(2024, 8, 11, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9143));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9582));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9332), new DateTime(2024, 8, 15, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9336), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9477), new DateTime(2024, 8, 25, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(9479), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7961));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7758));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7958));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7960));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7979));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7983));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7985));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 419, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 5, 13, 58, 26, 420, DateTimeKind.Utc).AddTicks(7113));
        }
    }
}
