using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditeOnNewsAndAboutPage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHidden",
                table: "OurGoals",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHidden",
                table: "News",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsAboutHidden",
                table: "AboutAwardPage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsGoalsHidden",
                table: "AboutAwardPage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsOurVisionHidden",
                table: "AboutAwardPage",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsAboutHidden", "IsGoalsHidden", "IsOurVisionHidden" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7512), false, false, false });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6022), new DateTime(2024, 7, 3, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6026), new DateTime(2024, 6, 28, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6029) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6031), new DateTime(2024, 7, 8, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6036), new DateTime(2024, 7, 3, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6037) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6038), new DateTime(2024, 7, 13, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6040), new DateTime(2024, 7, 8, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6042), new DateTime(2024, 7, 18, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6043), new DateTime(2024, 7, 13, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6044) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6046), new DateTime(2024, 7, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6047), new DateTime(2024, 7, 18, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6898));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6325), new DateTime(2024, 6, 23, 11, 18, 19, 609, DateTimeKind.Local).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6349), new DateTime(2024, 6, 23, 11, 18, 19, 609, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6351), new DateTime(2024, 6, 23, 11, 18, 19, 609, DateTimeKind.Local).AddTicks(6352) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6354), new DateTime(2024, 6, 23, 11, 18, 19, 609, DateTimeKind.Local).AddTicks(6355) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7903), new DateTime(2024, 6, 28, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7906), new DateTime(2024, 6, 25, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7913), new DateTime(2024, 6, 26, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7915), new DateTime(2024, 7, 1, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7917), new DateTime(2024, 6, 28, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7918), new DateTime(2024, 6, 29, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Type" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8153), 8 });

            migrationBuilder.InsertData(
                table: "ExplanatoryMessages",
                columns: new[] { "Id", "ArabicText", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishText", "LastModifiedAt", "LastModifiedBy", "Type", "isDeleted" },
                values: new object[] { 10, "الرجاء إتمام جميع المراحل الخاصة بالاستمارة الجديدة لتتمكن من الاشتراك بنجاح     --  يمكن الاشتراك بفئتين فقط (فئة ذات طابع فردي وفئة ذات طابع جماعي )خلال الدورة الواحدة ورفع الملفات المطلوبة عند تعبئة الاستمارة.", new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8155), null, null, "Please complete all stages of the new form to be able to participate successfully. You can participate in only two categories (an individual category and a group category) during one session and upload the required files when filling out the form.", null, null, 9, false });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8261), new DateTime(2024, 7, 3, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8264), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8415), new DateTime(2024, 7, 13, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(8417), "Saturday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7138));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7183));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsHidden" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7638), false });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsHidden" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7641), false });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsHidden" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7643), false });

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsHidden" },
                values: new object[] { new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7553), false });

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 608, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 23, 8, 18, 19, 609, DateTimeKind.Utc).AddTicks(6218));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "IsHidden",
                table: "OurGoals");

            migrationBuilder.DropColumn(
                name: "IsHidden",
                table: "News");

            migrationBuilder.DropColumn(
                name: "IsAboutHidden",
                table: "AboutAwardPage");

            migrationBuilder.DropColumn(
                name: "IsGoalsHidden",
                table: "AboutAwardPage");

            migrationBuilder.DropColumn(
                name: "IsOurVisionHidden",
                table: "AboutAwardPage");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(900), new DateTime(2024, 6, 23, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(911), new DateTime(2024, 6, 18, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(933), new DateTime(2024, 6, 28, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(937), new DateTime(2024, 6, 23, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(940) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(944), new DateTime(2024, 7, 3, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(948), new DateTime(2024, 6, 28, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(954), new DateTime(2024, 7, 8, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(958), new DateTime(2024, 7, 3, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(961) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(965), new DateTime(2024, 7, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(968), new DateTime(2024, 7, 8, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(5000));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2206), new DateTime(2024, 6, 13, 14, 1, 9, 344, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2380), new DateTime(2024, 6, 13, 14, 1, 9, 344, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2422), new DateTime(2024, 6, 13, 14, 1, 9, 344, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2616), new DateTime(2024, 6, 13, 14, 1, 9, 344, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(1963), new DateTime(2024, 6, 18, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(1970), new DateTime(2024, 6, 15, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(1993), new DateTime(2024, 6, 16, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(1996) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(2003), new DateTime(2024, 6, 21, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(2008), new DateTime(2024, 6, 18, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(2011), new DateTime(2024, 6, 19, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Type" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(978), 7 });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9413));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(3810), new DateTime(2024, 6, 23, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(3819), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4450), new DateTime(2024, 7, 3, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(4455), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6592));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6815));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6204));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 340, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 345, DateTimeKind.Utc).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 13, 11, 1, 9, 344, DateTimeKind.Utc).AddTicks(1725));
        }
    }
}
