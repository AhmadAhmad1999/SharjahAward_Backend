using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_DynamicAttributes_AddNewColumn_OrderId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "DynamicAttributes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9357), new DateTime(2024, 5, 10, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9369), new DateTime(2024, 5, 5, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9386), new DateTime(2024, 5, 15, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9388), new DateTime(2024, 5, 10, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9393), new DateTime(2024, 5, 20, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9395), new DateTime(2024, 5, 15, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9399), new DateTime(2024, 5, 25, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9402), new DateTime(2024, 5, 20, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9448), new DateTime(2024, 5, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9452), new DateTime(2024, 5, 25, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 226, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 226, DateTimeKind.Utc).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 226, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 226, DateTimeKind.Utc).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 226, DateTimeKind.Utc).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 226, DateTimeKind.Utc).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 226, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2599), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2608), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2612), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2616), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2619), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2623), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2627), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2630), 0 });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1022), new DateTime(2024, 4, 30, 16, 22, 10, 228, DateTimeKind.Local).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1134), new DateTime(2024, 4, 30, 16, 22, 10, 228, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1143), new DateTime(2024, 4, 30, 16, 22, 10, 228, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1150), new DateTime(2024, 4, 30, 16, 22, 10, 228, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3018), new DateTime(2024, 5, 5, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3023), new DateTime(2024, 5, 2, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3036), new DateTime(2024, 5, 3, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3041), new DateTime(2024, 5, 8, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3044), new DateTime(2024, 5, 5, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3045), new DateTime(2024, 5, 6, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(4570), new DateTime(2024, 5, 10, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(4845), new DateTime(2024, 5, 20, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(456));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "DynamicAttributes");

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
        }
    }
}
