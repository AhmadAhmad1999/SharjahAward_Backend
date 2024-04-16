using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeder_PermissionHeaders_Permissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7285), new DateTime(2024, 4, 26, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7303), new DateTime(2024, 4, 21, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7323), new DateTime(2024, 5, 1, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7327), new DateTime(2024, 4, 26, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7333), new DateTime(2024, 5, 6, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7337), new DateTime(2024, 5, 1, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7343), new DateTime(2024, 5, 11, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7347), new DateTime(2024, 5, 6, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7353), new DateTime(2024, 5, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7358), new DateTime(2024, 5, 11, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 927, DateTimeKind.Utc).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 927, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 927, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 927, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 927, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 927, DateTimeKind.Utc).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 927, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RecordIdOnRelation" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1721), 2 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9166), new DateTime(2024, 4, 16, 15, 59, 9, 929, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9301), new DateTime(2024, 4, 16, 15, 59, 9, 929, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9315), new DateTime(2024, 4, 16, 15, 59, 9, 929, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9327), new DateTime(2024, 4, 16, 15, 59, 9, 929, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5090), new DateTime(2024, 4, 21, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5100), new DateTime(2024, 4, 18, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5114), new DateTime(2024, 4, 19, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5122), new DateTime(2024, 4, 24, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5127), new DateTime(2024, 4, 21, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5130), new DateTime(2024, 4, 22, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(7915), new DateTime(2024, 4, 26, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8310), new DateTime(2024, 5, 6, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.InsertData(
                table: "PermissionHeaders",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "isDeleted" },
                values: new object[] { 1, new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(3818), null, null, null, null, "إدارة الدورات", false });

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "PermissionHeaderId", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(4907), null, null, null, null, "عرض الدورات", 1, false },
                    { 2, new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(4913), null, null, null, null, "إضافة دورة", 1, false },
                    { 3, new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(4918), null, null, null, null, "عرض معلومات دورة", 1, false },
                    { 4, new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(4924), null, null, null, null, "تعديل دورة", 1, false },
                    { 5, new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(4929), null, null, null, null, "حذف دورة", 1, false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7867), new DateTime(2024, 4, 26, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7875), new DateTime(2024, 4, 21, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7885), new DateTime(2024, 5, 1, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7888), new DateTime(2024, 4, 26, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7891), new DateTime(2024, 5, 6, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7893), new DateTime(2024, 5, 1, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7897), new DateTime(2024, 5, 11, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7900), new DateTime(2024, 5, 6, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7903), new DateTime(2024, 5, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7907), new DateTime(2024, 5, 11, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RecordIdOnRelation" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(393), 1 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9270), new DateTime(2024, 4, 16, 12, 59, 20, 94, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9364), new DateTime(2024, 4, 16, 12, 59, 20, 94, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9370), new DateTime(2024, 4, 16, 12, 59, 20, 94, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9376), new DateTime(2024, 4, 16, 12, 59, 20, 94, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(679), new DateTime(2024, 4, 21, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(687), new DateTime(2024, 4, 18, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(698), new DateTime(2024, 4, 19, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(702), new DateTime(2024, 4, 24, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(706), new DateTime(2024, 4, 21, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(708), new DateTime(2024, 4, 22, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(1830), new DateTime(2024, 4, 26, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2101), new DateTime(2024, 5, 6, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8782));
        }
    }
}
