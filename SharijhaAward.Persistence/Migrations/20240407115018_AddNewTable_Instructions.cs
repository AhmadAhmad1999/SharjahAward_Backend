using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable_Instructions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructions", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructions");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6484), new DateTime(2024, 5, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6487), new DateTime(2024, 5, 2, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6488) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6474), new DateTime(2024, 5, 2, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6477), new DateTime(2024, 4, 27, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6445), new DateTime(2024, 4, 27, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6449), new DateTime(2024, 4, 22, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6450) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6436), new DateTime(2024, 4, 22, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6438), new DateTime(2024, 4, 17, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6440) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6411), new DateTime(2024, 4, 17, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6421), new DateTime(2024, 4, 12, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 985, DateTimeKind.Utc).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 985, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 985, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 985, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 985, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 985, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 985, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7629), new DateTime(2024, 4, 7, 11, 37, 59, 986, DateTimeKind.Local).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7740), new DateTime(2024, 4, 7, 11, 37, 59, 986, DateTimeKind.Local).AddTicks(7744) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7771), new DateTime(2024, 4, 7, 11, 37, 59, 986, DateTimeKind.Local).AddTicks(7775) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7784), new DateTime(2024, 4, 7, 11, 37, 59, 986, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5495), new DateTime(2024, 4, 12, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5527), new DateTime(2024, 4, 9, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 4, 10, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5545), new DateTime(2024, 4, 15, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5549), new DateTime(2024, 4, 12, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5551), new DateTime(2024, 4, 13, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7040), new DateTime(2024, 4, 17, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7310), new DateTime(2024, 4, 27, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7582));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 984, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8559));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 7, 9, 37, 59, 986, DateTimeKind.Utc).AddTicks(8531));
        }
    }
}
