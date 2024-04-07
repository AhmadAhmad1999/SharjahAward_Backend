using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_EducationalClass_CycleId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CycleId",
                table: "EducationalClasses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(237), new DateTime(2024, 5, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(241), new DateTime(2024, 5, 2, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(226), new DateTime(2024, 5, 2, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(229), new DateTime(2024, 4, 27, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(231) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(213), new DateTime(2024, 4, 27, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(217), new DateTime(2024, 4, 22, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(201), new DateTime(2024, 4, 22, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(204), new DateTime(2024, 4, 17, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(206) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(177), new DateTime(2024, 4, 17, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(184), new DateTime(2024, 4, 12, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1150));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 449, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 449, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 449, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 449, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 449, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 449, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 449, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1664), new DateTime(2024, 4, 7, 10, 1, 7, 451, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1781), new DateTime(2024, 4, 7, 10, 1, 7, 451, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1796), new DateTime(2024, 4, 7, 10, 1, 7, 451, DateTimeKind.Local).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1810), new DateTime(2024, 4, 7, 10, 1, 7, 451, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2969), new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1") });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2979), new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1") });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2985), new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1") });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2991), new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1") });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2998), new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1") });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3005), new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1") });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3012), new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1") });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3021), new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1") });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3028), new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1") });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3035), new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1") });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3041), new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1") });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                columns: new[] { "CreatedAt", "CycleId" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3048), new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1") });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1605), new DateTime(2024, 4, 12, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1639), new DateTime(2024, 4, 9, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1653), new DateTime(2024, 4, 10, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1662), new DateTime(2024, 4, 15, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1670), new DateTime(2024, 4, 12, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1673), new DateTime(2024, 4, 13, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(3789), new DateTime(2024, 4, 17, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(3801), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4116), new DateTime(2024, 4, 27, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4125), "Saturday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 448, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 8, 1, 7, 451, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.CreateIndex(
                name: "IX_EducationalClasses_CycleId",
                table: "EducationalClasses",
                column: "CycleId");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationalClasses_Cycles_CycleId",
                table: "EducationalClasses",
                column: "CycleId",
                principalTable: "Cycles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(753), new DateTime(2024, 5, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(755), new DateTime(2024, 4, 29, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(757) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(744), new DateTime(2024, 4, 29, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(747), new DateTime(2024, 4, 24, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(736), new DateTime(2024, 4, 24, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(738), new DateTime(2024, 4, 19, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(739) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(727), new DateTime(2024, 4, 19, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(729), new DateTime(2024, 4, 14, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(730) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(701), new DateTime(2024, 4, 14, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(711), new DateTime(2024, 4, 9, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1871), new DateTime(2024, 4, 4, 14, 39, 19, 204, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1976), new DateTime(2024, 4, 4, 14, 39, 19, 204, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1987), new DateTime(2024, 4, 4, 14, 39, 19, 204, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1998), new DateTime(2024, 4, 4, 14, 39, 19, 204, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 4, 12, 39, 19, 201, DateTimeKind.Utc).AddTicks(9782), new DateTime(2024, 4, 9, 12, 39, 19, 201, DateTimeKind.Utc).AddTicks(9813), new DateTime(2024, 4, 6, 12, 39, 19, 201, DateTimeKind.Utc).AddTicks(9824), new DateTime(2024, 4, 7, 12, 39, 19, 201, DateTimeKind.Utc).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 4, 12, 39, 19, 201, DateTimeKind.Utc).AddTicks(9829), new DateTime(2024, 4, 12, 12, 39, 19, 201, DateTimeKind.Utc).AddTicks(9835), new DateTime(2024, 4, 9, 12, 39, 19, 201, DateTimeKind.Utc).AddTicks(9836), new DateTime(2024, 4, 10, 12, 39, 19, 201, DateTimeKind.Utc).AddTicks(9837) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(1776), new DateTime(2024, 4, 14, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(1784), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2026), new DateTime(2024, 4, 24, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2032), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2122));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 202, DateTimeKind.Utc).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3107));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1587));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 4, 12, 39, 19, 204, DateTimeKind.Utc).AddTicks(2725));
        }
    }
}
