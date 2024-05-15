using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditOnSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5921), new DateTime(2024, 5, 25, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5934), new DateTime(2024, 5, 20, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5945) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5948), new DateTime(2024, 5, 30, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5951), new DateTime(2024, 5, 25, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5954), new DateTime(2024, 6, 4, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5957), new DateTime(2024, 5, 30, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5960), new DateTime(2024, 6, 9, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5965), new DateTime(2024, 6, 4, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5969), new DateTime(2024, 6, 14, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5971), new DateTime(2024, 6, 9, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryClassification", "CreatedAt" },
                values: new object[] { 0, new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8845) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryClassification", "CreatedAt" },
                values: new object[] { 0, new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryClassification", "CreatedAt" },
                values: new object[] { 1, new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryClassification", "CreatedAt" },
                values: new object[] { 1, new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryClassification", "CreatedAt" },
                values: new object[] { 1, new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9444));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9451));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6687), new DateTime(2024, 5, 15, 16, 48, 16, 678, DateTimeKind.Local).AddTicks(6695) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6814), new DateTime(2024, 5, 15, 16, 48, 16, 678, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6821), new DateTime(2024, 5, 15, 16, 48, 16, 678, DateTimeKind.Local).AddTicks(6823) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6829), new DateTime(2024, 5, 15, 16, 48, 16, 678, DateTimeKind.Local).AddTicks(6832) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8697), new DateTime(2024, 5, 20, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8702), new DateTime(2024, 5, 17, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8715), new DateTime(2024, 5, 18, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8717) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8720), new DateTime(2024, 5, 23, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8724), new DateTime(2024, 5, 20, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8726), new DateTime(2024, 5, 21, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9696));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9704));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9708));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(9783), new DateTime(2024, 5, 25, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(9792) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 15, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(110), new DateTime(2024, 6, 4, 13, 48, 16, 677, DateTimeKind.Utc).AddTicks(113) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8180));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9344));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9267));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 676, DateTimeKind.Utc).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 679, DateTimeKind.Utc).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 13, 48, 16, 678, DateTimeKind.Utc).AddTicks(6421));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8370), new DateTime(2024, 5, 25, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8381), new DateTime(2024, 5, 20, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8392) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8395), new DateTime(2024, 5, 30, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8398), new DateTime(2024, 5, 25, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8403), new DateTime(2024, 6, 4, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8405), new DateTime(2024, 5, 30, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8407) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8409), new DateTime(2024, 6, 9, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8411), new DateTime(2024, 6, 4, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8413) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8415), new DateTime(2024, 6, 14, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8417), new DateTime(2024, 6, 9, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2989));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryClassification", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryClassification", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryClassification", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryClassification", "CreatedAt" },
                values: new object[] { 0, new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryClassification", "CreatedAt" },
                values: new object[] { 0, new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(9593), new DateTime(2024, 5, 15, 15, 38, 57, 81, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(9698), new DateTime(2024, 5, 15, 15, 38, 57, 81, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(9705), new DateTime(2024, 5, 15, 15, 38, 57, 81, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(9728), new DateTime(2024, 5, 15, 15, 38, 57, 81, DateTimeKind.Local).AddTicks(9730) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(125), new DateTime(2024, 5, 20, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(129), new DateTime(2024, 5, 17, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(140), new DateTime(2024, 5, 18, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(141) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(144), new DateTime(2024, 5, 23, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(147), new DateTime(2024, 5, 20, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(148), new DateTime(2024, 5, 21, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1078), new DateTime(2024, 5, 25, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1082) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1323), new DateTime(2024, 6, 4, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(1326) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1165));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 79, DateTimeKind.Utc).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 80, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 82, DateTimeKind.Utc).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 12, 38, 57, 81, DateTimeKind.Utc).AddTicks(8998));
        }
    }
}
