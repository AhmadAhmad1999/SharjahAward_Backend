using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_Categories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "WinningScore",
                table: "Categories",
                type: "real",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "FinalArbitrationQualificationMark",
                table: "Categories",
                type: "real",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<float>(
                name: "MinimumAmountToObtainACertificateOfParticipation",
                table: "Categories",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "MinimumAmountToParticipateInTheAward",
                table: "Categories",
                type: "real",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(101), new DateTime(2024, 4, 24, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(106), new DateTime(2024, 4, 19, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 4, 29, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(122), new DateTime(2024, 4, 24, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(125), new DateTime(2024, 5, 4, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(127), new DateTime(2024, 4, 29, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(130), new DateTime(2024, 5, 9, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(133), new DateTime(2024, 5, 4, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(136), new DateTime(2024, 5, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(138), new DateTime(2024, 5, 9, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FinalArbitrationQualificationMark", "MinimumAmountToObtainACertificateOfParticipation", "MinimumAmountToParticipateInTheAward", "WinningScore" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(429), 0f, null, null, 0f });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FinalArbitrationQualificationMark", "MinimumAmountToObtainACertificateOfParticipation", "MinimumAmountToParticipateInTheAward", "WinningScore" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(444), 0f, null, null, 0f });

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 635, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 635, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 635, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 635, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 4, 14, 13, 58, 54, 636, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1137), new DateTime(2024, 4, 14, 13, 58, 54, 636, DateTimeKind.Local).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1142), new DateTime(2024, 4, 14, 13, 58, 54, 636, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1148), new DateTime(2024, 4, 14, 13, 58, 54, 636, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2796), new DateTime(2024, 4, 19, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2804), new DateTime(2024, 4, 16, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2816), new DateTime(2024, 4, 17, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2820), new DateTime(2024, 4, 22, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2823), new DateTime(2024, 4, 19, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2824), new DateTime(2024, 4, 20, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4205), new DateTime(2024, 4, 24, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4210) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4455), new DateTime(2024, 5, 4, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "SubscriberId" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1726), "ABC123" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(812));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinimumAmountToObtainACertificateOfParticipation",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "MinimumAmountToParticipateInTheAward",
                table: "Categories");

            migrationBuilder.AlterColumn<int>(
                name: "WinningScore",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FinalArbitrationQualificationMark",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2272), new DateTime(2024, 4, 24, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2281), new DateTime(2024, 4, 19, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2293), new DateTime(2024, 4, 29, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2295), new DateTime(2024, 4, 24, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2298), new DateTime(2024, 5, 4, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2300), new DateTime(2024, 4, 29, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2304), new DateTime(2024, 5, 9, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2308), new DateTime(2024, 5, 4, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2311), new DateTime(2024, 5, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2314), new DateTime(2024, 5, 9, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 764, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "FinalArbitrationQualificationMark", "WinningScore" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2621), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "FinalArbitrationQualificationMark", "WinningScore" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2635), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3301), new DateTime(2024, 4, 14, 13, 3, 0, 766, DateTimeKind.Local).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3397), new DateTime(2024, 4, 14, 13, 3, 0, 766, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3403), new DateTime(2024, 4, 14, 13, 3, 0, 766, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3408), new DateTime(2024, 4, 14, 13, 3, 0, 766, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 764, DateTimeKind.Utc).AddTicks(8281), new DateTime(2024, 4, 19, 11, 3, 0, 764, DateTimeKind.Utc).AddTicks(8289), new DateTime(2024, 4, 16, 11, 3, 0, 764, DateTimeKind.Utc).AddTicks(8300), new DateTime(2024, 4, 17, 11, 3, 0, 764, DateTimeKind.Utc).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 764, DateTimeKind.Utc).AddTicks(8304), new DateTime(2024, 4, 22, 11, 3, 0, 764, DateTimeKind.Utc).AddTicks(8306), new DateTime(2024, 4, 19, 11, 3, 0, 764, DateTimeKind.Utc).AddTicks(8307), new DateTime(2024, 4, 20, 11, 3, 0, 764, DateTimeKind.Utc).AddTicks(8309) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 764, DateTimeKind.Utc).AddTicks(9703), new DateTime(2024, 4, 24, 11, 3, 0, 764, DateTimeKind.Utc).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 764, DateTimeKind.Utc).AddTicks(9918), new DateTime(2024, 5, 4, 11, 3, 0, 764, DateTimeKind.Utc).AddTicks(9921) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3502));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 765, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3583));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "SubscriberId" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(4187), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3048));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 3, 0, 766, DateTimeKind.Utc).AddTicks(3065));
        }
    }
}
