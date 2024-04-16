using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_Categories_RemoveColumn_Status : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9266), new DateTime(2024, 4, 26, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9282), new DateTime(2024, 4, 21, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9302), new DateTime(2024, 5, 1, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9304), new DateTime(2024, 4, 26, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9307), new DateTime(2024, 5, 6, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9308), new DateTime(2024, 5, 1, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9311), new DateTime(2024, 5, 11, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9314), new DateTime(2024, 5, 6, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9316), new DateTime(2024, 5, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9318), new DateTime(2024, 5, 11, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 4, 16, 10, 3, 44, 281, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(253), new DateTime(2024, 4, 16, 10, 3, 44, 281, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(259), new DateTime(2024, 4, 16, 10, 3, 44, 281, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(264), new DateTime(2024, 4, 16, 10, 3, 44, 281, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8784), new DateTime(2024, 4, 21, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8793), new DateTime(2024, 4, 18, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8802), new DateTime(2024, 4, 19, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8807), new DateTime(2024, 4, 24, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8809), new DateTime(2024, 4, 21, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8811), new DateTime(2024, 4, 22, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(9996), new DateTime(2024, 4, 26, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(2), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(229), new DateTime(2024, 5, 6, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(232), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9975));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6243), new DateTime(2024, 4, 25, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6248), new DateTime(2024, 4, 20, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6264), new DateTime(2024, 4, 30, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6267), new DateTime(2024, 4, 25, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6271), new DateTime(2024, 5, 5, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6273), new DateTime(2024, 4, 30, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6274) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6277), new DateTime(2024, 5, 10, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6279), new DateTime(2024, 5, 5, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6280) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6283), new DateTime(2024, 5, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6285), new DateTime(2024, 5, 10, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6287) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(68));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6610), 0 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Status" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6627), 0 });

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 205, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(9001));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8889));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7350), new DateTime(2024, 4, 15, 15, 34, 37, 206, DateTimeKind.Local).AddTicks(7357) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7457), new DateTime(2024, 4, 15, 15, 34, 37, 206, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7465), new DateTime(2024, 4, 15, 15, 34, 37, 206, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7472), new DateTime(2024, 4, 15, 15, 34, 37, 206, DateTimeKind.Local).AddTicks(7476) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7463), new DateTime(2024, 4, 20, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7472), new DateTime(2024, 4, 17, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7483), new DateTime(2024, 4, 18, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7488), new DateTime(2024, 4, 23, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7492), new DateTime(2024, 4, 20, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7493), new DateTime(2024, 4, 21, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(7495) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9198), new DateTime(2024, 4, 25, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9203), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9440), new DateTime(2024, 5, 5, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9444), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9702));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 204, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 34, 37, 206, DateTimeKind.Utc).AddTicks(7107));
        }
    }
}
