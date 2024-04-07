using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_Instructions_UniqueConstraintOnSlugColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Instructions",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5240), new DateTime(2024, 5, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5244), new DateTime(2024, 5, 2, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5225), new DateTime(2024, 5, 2, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5229), new DateTime(2024, 4, 27, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5209), new DateTime(2024, 4, 27, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5213), new DateTime(2024, 4, 22, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5193), new DateTime(2024, 4, 22, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5197), new DateTime(2024, 4, 17, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5157), new DateTime(2024, 4, 17, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5168), new DateTime(2024, 4, 12, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 20, DateTimeKind.Utc).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 20, DateTimeKind.Utc).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 20, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 20, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 20, DateTimeKind.Utc).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 20, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 20, DateTimeKind.Utc).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(2290));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(2297));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(8927), new DateTime(2024, 4, 7, 14, 38, 50, 23, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(9087), new DateTime(2024, 4, 7, 14, 38, 50, 23, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(9108), new DateTime(2024, 4, 7, 14, 38, 50, 23, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(9128), new DateTime(2024, 4, 7, 14, 38, 50, 23, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 12, 38, 50, 17, DateTimeKind.Utc).AddTicks(6745), new DateTime(2024, 4, 12, 12, 38, 50, 17, DateTimeKind.Utc).AddTicks(6786), new DateTime(2024, 4, 9, 12, 38, 50, 17, DateTimeKind.Utc).AddTicks(6803), new DateTime(2024, 4, 10, 12, 38, 50, 17, DateTimeKind.Utc).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 12, 38, 50, 17, DateTimeKind.Utc).AddTicks(6812), new DateTime(2024, 4, 15, 12, 38, 50, 17, DateTimeKind.Utc).AddTicks(6822), new DateTime(2024, 4, 12, 12, 38, 50, 17, DateTimeKind.Utc).AddTicks(6825), new DateTime(2024, 4, 13, 12, 38, 50, 17, DateTimeKind.Utc).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 7, 12, 38, 50, 17, DateTimeKind.Utc).AddTicks(9956), new DateTime(2024, 4, 17, 12, 38, 50, 17, DateTimeKind.Utc).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(373), new DateTime(2024, 4, 27, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(383) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 18, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(9537));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 23, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 12, 38, 50, 24, DateTimeKind.Utc).AddTicks(635));

            migrationBuilder.CreateIndex(
                name: "IX_Instructions_Slug",
                table: "Instructions",
                column: "Slug",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Instructions_Slug",
                table: "Instructions");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Instructions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8749), new DateTime(2024, 5, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8752), new DateTime(2024, 5, 2, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8741), new DateTime(2024, 5, 2, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8744), new DateTime(2024, 4, 27, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8665), new DateTime(2024, 4, 27, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8667), new DateTime(2024, 4, 22, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8656), new DateTime(2024, 4, 22, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8658), new DateTime(2024, 4, 17, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8625), new DateTime(2024, 4, 17, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8639), new DateTime(2024, 4, 12, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8649) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 717, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 717, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 717, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 717, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 717, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 717, DateTimeKind.Utc).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 717, DateTimeKind.Utc).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9900), new DateTime(2024, 4, 7, 13, 50, 13, 718, DateTimeKind.Local).AddTicks(9909) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(13), new DateTime(2024, 4, 7, 13, 50, 13, 719, DateTimeKind.Local).AddTicks(17) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(26), new DateTime(2024, 4, 7, 13, 50, 13, 719, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(37), new DateTime(2024, 4, 7, 13, 50, 13, 719, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9726));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9810));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(3033), new DateTime(2024, 4, 12, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(3065), new DateTime(2024, 4, 9, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(3075), new DateTime(2024, 4, 10, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(3077) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(3080), new DateTime(2024, 4, 15, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(3084), new DateTime(2024, 4, 12, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(3085), new DateTime(2024, 4, 13, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(3086) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(7989));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(4748), new DateTime(2024, 4, 17, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 4, 27, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 716, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1240));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 718, DateTimeKind.Utc).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 11, 50, 13, 719, DateTimeKind.Utc).AddTicks(826));
        }
    }
}
