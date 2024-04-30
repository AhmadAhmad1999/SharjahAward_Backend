using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_ArbitrationScales_AddNewColumn_CategoryId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ArbitrationScales",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3185), new DateTime(2024, 5, 10, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3192), new DateTime(2024, 5, 5, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3204), new DateTime(2024, 5, 15, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3206), new DateTime(2024, 5, 10, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3208) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3211), new DateTime(2024, 5, 20, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3214), new DateTime(2024, 5, 15, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3217), new DateTime(2024, 5, 25, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3219), new DateTime(2024, 5, 20, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3222), new DateTime(2024, 5, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3224), new DateTime(2024, 5, 25, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7811));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 120, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 120, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 120, DateTimeKind.Utc).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 120, DateTimeKind.Utc).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 120, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 120, DateTimeKind.Utc).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 120, DateTimeKind.Utc).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4250), new DateTime(2024, 4, 30, 15, 23, 6, 121, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4349), new DateTime(2024, 4, 30, 15, 23, 6, 121, DateTimeKind.Local).AddTicks(4351) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4356), new DateTime(2024, 4, 30, 15, 23, 6, 121, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4363), new DateTime(2024, 4, 30, 15, 23, 6, 121, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5803), new DateTime(2024, 5, 5, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5808), new DateTime(2024, 5, 2, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5820), new DateTime(2024, 5, 3, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5826), new DateTime(2024, 5, 8, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5828), new DateTime(2024, 5, 5, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5830), new DateTime(2024, 5, 6, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(6770), new DateTime(2024, 5, 10, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7303), new DateTime(2024, 5, 20, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 119, DateTimeKind.Utc).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 23, 6, 121, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.CreateIndex(
                name: "IX_ArbitrationScales_CategoryId",
                table: "ArbitrationScales",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArbitrationScales_Categories_CategoryId",
                table: "ArbitrationScales",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArbitrationScales_Categories_CategoryId",
                table: "ArbitrationScales");

            migrationBuilder.DropIndex(
                name: "IX_ArbitrationScales_CategoryId",
                table: "ArbitrationScales");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ArbitrationScales");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8320), new DateTime(2024, 5, 10, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8323), new DateTime(2024, 5, 5, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8329), new DateTime(2024, 5, 15, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8330), new DateTime(2024, 5, 10, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8332), new DateTime(2024, 5, 20, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8335), new DateTime(2024, 5, 15, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8337), new DateTime(2024, 5, 25, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8338), new DateTime(2024, 5, 20, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8370), new DateTime(2024, 5, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8371), new DateTime(2024, 5, 25, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8788), new DateTime(2024, 4, 30, 15, 11, 16, 183, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8804), new DateTime(2024, 4, 30, 15, 11, 16, 183, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8807), new DateTime(2024, 4, 30, 15, 11, 16, 183, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8809), new DateTime(2024, 4, 30, 15, 11, 16, 183, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1656), new DateTime(2024, 5, 5, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1658), new DateTime(2024, 5, 2, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1665), new DateTime(2024, 5, 3, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1668), new DateTime(2024, 5, 8, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1669), new DateTime(2024, 5, 5, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1670), new DateTime(2024, 5, 6, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2092), new DateTime(2024, 5, 10, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2116), new DateTime(2024, 5, 20, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8669));
        }
    }
}
