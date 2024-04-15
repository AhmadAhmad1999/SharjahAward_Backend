using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_EducationalClasses_RemoveCycleId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationalClasses_Cycles_CycleId",
                table: "EducationalClasses");

            migrationBuilder.DropIndex(
                name: "IX_EducationalClasses_CycleId",
                table: "EducationalClasses");

            migrationBuilder.DropColumn(
                name: "CycleId",
                table: "EducationalClasses");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6071), new DateTime(2024, 4, 25, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6081), new DateTime(2024, 4, 20, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6095), new DateTime(2024, 4, 30, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6098), new DateTime(2024, 4, 25, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6102), new DateTime(2024, 5, 5, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6104), new DateTime(2024, 4, 30, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6108), new DateTime(2024, 5, 10, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6110), new DateTime(2024, 5, 5, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6114), new DateTime(2024, 5, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6116), new DateTime(2024, 5, 10, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 227, DateTimeKind.Utc).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 227, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 227, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 227, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 227, DateTimeKind.Utc).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 227, DateTimeKind.Utc).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 227, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7152), new DateTime(2024, 4, 15, 12, 48, 35, 228, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7260), new DateTime(2024, 4, 15, 12, 48, 35, 228, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7268), new DateTime(2024, 4, 15, 12, 48, 35, 228, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7274), new DateTime(2024, 4, 15, 12, 48, 35, 228, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3412), new DateTime(2024, 4, 20, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3425), new DateTime(2024, 4, 17, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3443), new DateTime(2024, 4, 18, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3448), new DateTime(2024, 4, 23, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3452), new DateTime(2024, 4, 20, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3454), new DateTime(2024, 4, 21, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5025), new DateTime(2024, 4, 25, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5275), new DateTime(2024, 5, 5, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6919));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CycleId",
                table: "EducationalClasses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5148), new DateTime(2024, 4, 25, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5157), new DateTime(2024, 4, 20, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5170), new DateTime(2024, 4, 30, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5172), new DateTime(2024, 4, 25, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5177), new DateTime(2024, 5, 5, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5179), new DateTime(2024, 4, 30, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5183), new DateTime(2024, 5, 10, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5185), new DateTime(2024, 5, 5, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5189), new DateTime(2024, 5, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5191), new DateTime(2024, 5, 10, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6414), new DateTime(2024, 4, 15, 11, 0, 9, 44, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6523), new DateTime(2024, 4, 15, 11, 0, 9, 44, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6533), new DateTime(2024, 4, 15, 11, 0, 9, 44, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6541), new DateTime(2024, 4, 15, 11, 0, 9, 44, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8300), 1 });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8305), 1 });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8309), 1 });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8312), 1 });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8317), 1 });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8320), 1 });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8323), 1 });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8329), 1 });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8333), 1 });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8340), 1 });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8343), 1 });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8347), 1 });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6768), new DateTime(2024, 4, 20, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6780), new DateTime(2024, 4, 17, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6793), new DateTime(2024, 4, 18, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6799), new DateTime(2024, 4, 23, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6802), new DateTime(2024, 4, 20, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6804), new DateTime(2024, 4, 21, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9201), new DateTime(2024, 4, 25, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9515), new DateTime(2024, 5, 5, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.CreateIndex(
                name: "IX_EducationalClasses_CycleId",
                table: "EducationalClasses",
                column: "CycleId");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationalClasses_Cycles_CycleId",
                table: "EducationalClasses",
                column: "CycleId",
                principalTable: "Cycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
