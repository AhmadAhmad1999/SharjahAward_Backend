using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTables_CategoryEducationalClass_ProvidedForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryEducationalClassId",
                table: "ProvidedForms",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfExpectedWinners",
                table: "CategoryEducationalClasses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8371), new DateTime(2024, 5, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8375), new DateTime(2024, 4, 29, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8378) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8355), new DateTime(2024, 4, 29, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8359), new DateTime(2024, 4, 24, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8339), new DateTime(2024, 4, 24, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8344), new DateTime(2024, 4, 19, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8323), new DateTime(2024, 4, 19, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8327), new DateTime(2024, 4, 14, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8284), new DateTime(2024, 4, 14, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8298), new DateTime(2024, 4, 9, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8311) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2907));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 324, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 324, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 324, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 324, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 324, DateTimeKind.Utc).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 324, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 324, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"),
                columns: new[] { "GroupCategoryNumber", "IndividualCategoryNumber" },
                values: new object[] { 10, 10 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(3045));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(3074));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(375), new DateTime(2024, 4, 4, 12, 6, 27, 327, DateTimeKind.Local).AddTicks(387) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(516), new DateTime(2024, 4, 4, 12, 6, 27, 327, DateTimeKind.Local).AddTicks(523) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(538), new DateTime(2024, 4, 4, 12, 6, 27, 327, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(558), new DateTime(2024, 4, 4, 12, 6, 27, 327, DateTimeKind.Local).AddTicks(563) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 6, 27, 322, DateTimeKind.Utc).AddTicks(7729), new DateTime(2024, 4, 9, 10, 6, 27, 322, DateTimeKind.Utc).AddTicks(7769), new DateTime(2024, 4, 6, 10, 6, 27, 322, DateTimeKind.Utc).AddTicks(7785), new DateTime(2024, 4, 7, 10, 6, 27, 322, DateTimeKind.Utc).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 6, 27, 322, DateTimeKind.Utc).AddTicks(7794), new DateTime(2024, 4, 12, 10, 6, 27, 322, DateTimeKind.Utc).AddTicks(7802), new DateTime(2024, 4, 9, 10, 6, 27, 322, DateTimeKind.Utc).AddTicks(7805), new DateTime(2024, 4, 10, 10, 6, 27, 322, DateTimeKind.Utc).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(1130), new DateTime(2024, 4, 14, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(1147), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(1503), new DateTime(2024, 4, 24, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(1513), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 323, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryEducationalClassId", "CreatedAt" },
                values: new object[] { null, new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2715) });

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(962));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(1010));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(9873));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 326, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(1924));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 10, 6, 27, 327, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.CreateIndex(
                name: "IX_ProvidedForms_CategoryEducationalClassId",
                table: "ProvidedForms",
                column: "CategoryEducationalClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProvidedForms_CategoryEducationalClasses_CategoryEducationalClassId",
                table: "ProvidedForms",
                column: "CategoryEducationalClassId",
                principalTable: "CategoryEducationalClasses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProvidedForms_CategoryEducationalClasses_CategoryEducationalClassId",
                table: "ProvidedForms");

            migrationBuilder.DropIndex(
                name: "IX_ProvidedForms_CategoryEducationalClassId",
                table: "ProvidedForms");

            migrationBuilder.DropColumn(
                name: "CategoryEducationalClassId",
                table: "ProvidedForms");

            migrationBuilder.DropColumn(
                name: "NumberOfExpectedWinners",
                table: "CategoryEducationalClasses");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7408), new DateTime(2024, 5, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7410), new DateTime(2024, 4, 28, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7396), new DateTime(2024, 4, 28, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7400), new DateTime(2024, 4, 23, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7401) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7384), new DateTime(2024, 4, 23, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7386), new DateTime(2024, 4, 18, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7373), new DateTime(2024, 4, 18, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7377), new DateTime(2024, 4, 13, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7378) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7339), new DateTime(2024, 4, 13, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7352), new DateTime(2024, 4, 8, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7366) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1657));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"),
                columns: new[] { "GroupCategoryNumber", "IndividualCategoryNumber" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8799), new DateTime(2024, 4, 3, 13, 14, 49, 953, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8923), new DateTime(2024, 4, 3, 13, 14, 49, 953, DateTimeKind.Local).AddTicks(8927) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8937), new DateTime(2024, 4, 3, 13, 14, 49, 953, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8951), new DateTime(2024, 4, 3, 13, 14, 49, 953, DateTimeKind.Local).AddTicks(8954) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(56));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(62));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 14, 49, 950, DateTimeKind.Utc).AddTicks(8273), new DateTime(2024, 4, 8, 11, 14, 49, 950, DateTimeKind.Utc).AddTicks(8306), new DateTime(2024, 4, 5, 11, 14, 49, 950, DateTimeKind.Utc).AddTicks(8319), new DateTime(2024, 4, 6, 11, 14, 49, 950, DateTimeKind.Utc).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 14, 49, 950, DateTimeKind.Utc).AddTicks(8324), new DateTime(2024, 4, 11, 11, 14, 49, 950, DateTimeKind.Utc).AddTicks(8329), new DateTime(2024, 4, 8, 11, 14, 49, 950, DateTimeKind.Utc).AddTicks(8332), new DateTime(2024, 4, 9, 11, 14, 49, 950, DateTimeKind.Utc).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(671), new DateTime(2024, 4, 13, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(687), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 4, 23, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(966), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 954, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 11, 14, 49, 953, DateTimeKind.Utc).AddTicks(9829));
        }
    }
}
