using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_EducationalClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArabicName",
                table: "EducationalClasses");

            migrationBuilder.RenameColumn(
                name: "EnglishName",
                table: "EducationalClasses",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8148), new DateTime(2024, 5, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8153), new DateTime(2024, 4, 26, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8127), new DateTime(2024, 4, 26, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8132), new DateTime(2024, 4, 21, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8109), new DateTime(2024, 4, 21, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8114), new DateTime(2024, 4, 16, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8089), new DateTime(2024, 4, 16, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8094), new DateTime(2024, 4, 11, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8098) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8048), new DateTime(2024, 4, 11, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8059), new DateTime(2024, 4, 6, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7800));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8862));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9729));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 724, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 724, DateTimeKind.Utc).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 724, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 724, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 724, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 724, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 724, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4952));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4345));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(719), new DateTime(2024, 4, 1, 9, 41, 31, 727, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(872), new DateTime(2024, 4, 1, 9, 41, 31, 727, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(906), new DateTime(2024, 4, 1, 9, 41, 31, 727, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(938), new DateTime(2024, 4, 1, 9, 41, 31, 727, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3298), "الصف الأول" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3313), "الصف الثاني" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3322), "الصف الثالث" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3331), "الصف الرابع" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3341), "الصف الخامس" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3350), "الصف السادس" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3358), "الصف السابع" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3371), "الصف الثامن" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3381), "الصف التاسع" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3390), "الصف العاشر" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3398), "الصف الحادي عشر" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3408), "الصف الثاني عشر" });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 4, 6, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2592), new DateTime(2024, 4, 3, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2607), new DateTime(2024, 4, 4, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2610) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2616), new DateTime(2024, 4, 9, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2626), new DateTime(2024, 4, 6, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2630), new DateTime(2024, 4, 7, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(5781), new DateTime(2024, 4, 11, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(5799), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6176), new DateTime(2024, 4, 21, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6188), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 723, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(1643));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 726, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(2984));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 7, 41, 31, 727, DateTimeKind.Utc).AddTicks(2960));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "EducationalClasses",
                newName: "EnglishName");

            migrationBuilder.AddColumn<string>(
                name: "ArabicName",
                table: "EducationalClasses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9668), new DateTime(2024, 4, 30, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9672), new DateTime(2024, 4, 25, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9649), new DateTime(2024, 4, 25, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9654), new DateTime(2024, 4, 20, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9657) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9632), new DateTime(2024, 4, 20, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9636), new DateTime(2024, 4, 15, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9613), new DateTime(2024, 4, 15, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9618), new DateTime(2024, 4, 10, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9573), new DateTime(2024, 4, 10, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9585), new DateTime(2024, 4, 5, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4277));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(74));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 787, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 787, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 787, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 787, DateTimeKind.Utc).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 787, DateTimeKind.Utc).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 787, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 787, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(1392), new DateTime(2024, 3, 31, 15, 15, 45, 789, DateTimeKind.Local).AddTicks(1406) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(1548), new DateTime(2024, 3, 31, 15, 15, 45, 789, DateTimeKind.Local).AddTicks(1556) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(1573), new DateTime(2024, 3, 31, 15, 15, 45, 789, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(1597), new DateTime(2024, 3, 31, 15, 15, 45, 789, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الأول", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3089), "First class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الثاني", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3104), "Second class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الثالث", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3112), "Third class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الرابع", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3121), "Forth class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الخامس", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3129), "Fifth class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف السادس", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3137), "Sixth class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف السابع", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3145), "Seventh class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الثامن", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3156), "Eighth class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف التاسع", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3164), "Ninth class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف العاشر", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3173), "Tenth class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الحادي عشر", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3181), "Eleventh class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الحادي عشر", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3189), "Twelveth class" });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(190), new DateTime(2024, 4, 5, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(234), new DateTime(2024, 4, 2, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(250), new DateTime(2024, 4, 3, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(259), new DateTime(2024, 4, 8, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(268), new DateTime(2024, 4, 5, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(272), new DateTime(2024, 4, 6, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(2818), new DateTime(2024, 4, 10, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(2834), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(3224), new DateTime(2024, 4, 20, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(3235), "Saturday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 788, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(2835));
        }
    }
}
