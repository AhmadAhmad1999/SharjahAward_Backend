using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_Meetings_AddNewColumns_ArabicText_EnglishText : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArabicText",
                table: "Meetings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnglishText",
                table: "Meetings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(4978), new DateTime(2024, 5, 15, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(4987), new DateTime(2024, 5, 10, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5002), new DateTime(2024, 5, 20, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5005), new DateTime(2024, 5, 15, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5010), new DateTime(2024, 5, 25, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5012), new DateTime(2024, 5, 20, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5067), new DateTime(2024, 5, 30, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5070), new DateTime(2024, 5, 25, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5075), new DateTime(2024, 6, 4, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5078), new DateTime(2024, 5, 30, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 856, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 856, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 856, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 856, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 856, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 856, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 856, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6617), new DateTime(2024, 5, 5, 12, 12, 38, 858, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6728), new DateTime(2024, 5, 5, 12, 12, 38, 858, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6738), new DateTime(2024, 5, 5, 12, 12, 38, 858, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6750), new DateTime(2024, 5, 5, 12, 12, 38, 858, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9952), new DateTime(2024, 5, 10, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9961), new DateTime(2024, 5, 7, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9974), new DateTime(2024, 5, 8, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9980), new DateTime(2024, 5, 13, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9984), new DateTime(2024, 5, 10, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9987), new DateTime(2024, 5, 11, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(1675), new DateTime(2024, 5, 15, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2009), new DateTime(2024, 5, 25, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6253));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArabicText",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "EnglishText",
                table: "Meetings");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3166), new DateTime(2024, 5, 15, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3189), new DateTime(2024, 5, 10, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3215), new DateTime(2024, 5, 20, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3217), new DateTime(2024, 5, 15, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3221), new DateTime(2024, 5, 25, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3224), new DateTime(2024, 5, 20, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3228), new DateTime(2024, 5, 30, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3233), new DateTime(2024, 5, 25, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3239), new DateTime(2024, 6, 4, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3241), new DateTime(2024, 5, 30, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4614), new DateTime(2024, 5, 5, 10, 47, 43, 852, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4751), new DateTime(2024, 5, 5, 10, 47, 43, 852, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4759), new DateTime(2024, 5, 5, 10, 47, 43, 852, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4767), new DateTime(2024, 5, 5, 10, 47, 43, 852, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8431), new DateTime(2024, 5, 10, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8440), new DateTime(2024, 5, 7, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8453), new DateTime(2024, 5, 8, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8458), new DateTime(2024, 5, 13, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8461), new DateTime(2024, 5, 10, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8463), new DateTime(2024, 5, 11, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(9463), new DateTime(2024, 5, 15, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(9470) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(9743), new DateTime(2024, 5, 25, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(9747) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4322));
        }
    }
}
