using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable_ArbitratorClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArbitratorClass_Arbitrators_ArbitratorClassId",
                table: "ArbitratorClass");

            migrationBuilder.DropForeignKey(
                name: "FK_ArbitratorClass_CycleClass_CycleClassId",
                table: "ArbitratorClass");

            migrationBuilder.DropTable(
                name: "CycleClass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArbitratorClass",
                table: "ArbitratorClass");

            migrationBuilder.DropIndex(
                name: "IX_ArbitratorClass_CycleClassId",
                table: "ArbitratorClass");

            migrationBuilder.DropColumn(
                name: "CycleClassId",
                table: "ArbitratorClass");

            migrationBuilder.RenameTable(
                name: "ArbitratorClass",
                newName: "ArbitratorClasses");

            migrationBuilder.RenameColumn(
                name: "ArbitratorClassId",
                table: "ArbitratorClasses",
                newName: "EducationalClassId");

            migrationBuilder.RenameIndex(
                name: "IX_ArbitratorClass_ArbitratorClassId",
                table: "ArbitratorClasses",
                newName: "IX_ArbitratorClasses_EducationalClassId");

            migrationBuilder.AddColumn<Guid>(
                name: "ArbitratorId",
                table: "ArbitratorClasses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ArbitratorClasses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "ArbitratorClasses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "ArbitratorClasses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "ArbitratorClasses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArbitratorClasses",
                table: "ArbitratorClasses",
                column: "Id");

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
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(671), new DateTime(2024, 4, 13, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(687) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 3, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(960), new DateTime(2024, 4, 23, 11, 14, 49, 951, DateTimeKind.Utc).AddTicks(966) });

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

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorClasses_ArbitratorId",
                table: "ArbitratorClasses",
                column: "ArbitratorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArbitratorClasses_Arbitrators_ArbitratorId",
                table: "ArbitratorClasses",
                column: "ArbitratorId",
                principalTable: "Arbitrators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArbitratorClasses_EducationalClasses_EducationalClassId",
                table: "ArbitratorClasses",
                column: "EducationalClassId",
                principalTable: "EducationalClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArbitratorClasses_Arbitrators_ArbitratorId",
                table: "ArbitratorClasses");

            migrationBuilder.DropForeignKey(
                name: "FK_ArbitratorClasses_EducationalClasses_EducationalClassId",
                table: "ArbitratorClasses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ArbitratorClasses",
                table: "ArbitratorClasses");

            migrationBuilder.DropIndex(
                name: "IX_ArbitratorClasses_ArbitratorId",
                table: "ArbitratorClasses");

            migrationBuilder.DropColumn(
                name: "ArbitratorId",
                table: "ArbitratorClasses");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ArbitratorClasses");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ArbitratorClasses");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ArbitratorClasses");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "ArbitratorClasses");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "ArbitratorClasses");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "ArbitratorClasses");

            migrationBuilder.RenameTable(
                name: "ArbitratorClasses",
                newName: "ArbitratorClass");

            migrationBuilder.RenameColumn(
                name: "EducationalClassId",
                table: "ArbitratorClass",
                newName: "ArbitratorClassId");

            migrationBuilder.RenameIndex(
                name: "IX_ArbitratorClasses_EducationalClassId",
                table: "ArbitratorClass",
                newName: "IX_ArbitratorClass_ArbitratorClassId");

            migrationBuilder.AddColumn<int>(
                name: "CycleClassId",
                table: "ArbitratorClass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ArbitratorClass",
                table: "ArbitratorClass",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CycleClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CycleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EducationalClassId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CycleClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CycleClass_Cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "Cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CycleClass_EducationalClasses_EducationalClassId",
                        column: x => x.EducationalClassId,
                        principalTable: "EducationalClasses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3477), new DateTime(2024, 5, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3480), new DateTime(2024, 4, 28, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3466), new DateTime(2024, 4, 28, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3469), new DateTime(2024, 4, 23, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3457), new DateTime(2024, 4, 23, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3459), new DateTime(2024, 4, 18, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3447), new DateTime(2024, 4, 18, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3450), new DateTime(2024, 4, 13, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3419), new DateTime(2024, 4, 13, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3428), new DateTime(2024, 4, 8, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3439) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9080));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4313));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 978, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 978, DateTimeKind.Utc).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 978, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 978, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 978, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 978, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 978, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4767), new DateTime(2024, 4, 3, 11, 1, 5, 980, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4890), new DateTime(2024, 4, 3, 11, 1, 5, 980, DateTimeKind.Local).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4905), new DateTime(2024, 4, 3, 11, 1, 5, 980, DateTimeKind.Local).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4916), new DateTime(2024, 4, 3, 11, 1, 5, 980, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5704), new DateTime(2024, 4, 8, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5737), new DateTime(2024, 4, 5, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5752), new DateTime(2024, 4, 6, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5754) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5757), new DateTime(2024, 4, 11, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5761), new DateTime(2024, 4, 8, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5763), new DateTime(2024, 4, 9, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(5764) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(7817), new DateTime(2024, 4, 13, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(7829) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8198), new DateTime(2024, 4, 23, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8206) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 977, DateTimeKind.Utc).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 9, 1, 5, 980, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorClass_CycleClassId",
                table: "ArbitratorClass",
                column: "CycleClassId");

            migrationBuilder.CreateIndex(
                name: "IX_CycleClass_CycleId",
                table: "CycleClass",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_CycleClass_EducationalClassId",
                table: "CycleClass",
                column: "EducationalClassId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArbitratorClass_Arbitrators_ArbitratorClassId",
                table: "ArbitratorClass",
                column: "ArbitratorClassId",
                principalTable: "Arbitrators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArbitratorClass_CycleClass_CycleClassId",
                table: "ArbitratorClass",
                column: "CycleClassId",
                principalTable: "CycleClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
