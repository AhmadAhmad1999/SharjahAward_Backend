using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTables_Categories_EducationClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "CategoryClassification",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1795), new DateTime(2024, 5, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1800), new DateTime(2024, 4, 28, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1776), new DateTime(2024, 4, 28, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1781), new DateTime(2024, 4, 23, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1757), new DateTime(2024, 4, 23, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1761), new DateTime(2024, 4, 18, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1738), new DateTime(2024, 4, 18, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1743), new DateTime(2024, 4, 13, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1693), new DateTime(2024, 4, 13, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1709), new DateTime(2024, 4, 8, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 191, DateTimeKind.Utc).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 191, DateTimeKind.Utc).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 191, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 191, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 191, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 191, DateTimeKind.Utc).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 191, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4162), new DateTime(2024, 4, 3, 10, 29, 49, 193, DateTimeKind.Local).AddTicks(4177) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4311), new DateTime(2024, 4, 3, 10, 29, 49, 193, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4337), new DateTime(2024, 4, 3, 10, 29, 49, 193, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4358), new DateTime(2024, 4, 3, 10, 29, 49, 193, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الأول", new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6345), "First class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الثاني", new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6358), "Second class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الثالث", new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6367), "Third class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الرابع", new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6375), "Forth class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الخامس", new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6383), "Fifth class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف السادس", new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6391), "Sixth class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف السابع", new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6399), "Seventh class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الثامن", new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6408), "Eighth class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف التاسع", new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6418), "Ninth class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف العاشر", new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6427), "Tenth class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الحادي عشر", new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6436), "Eleventh class" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                columns: new[] { "ArabicName", "CreatedAt", "EnglishName" },
                values: new object[] { "الصف الثاني عشر", new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6444), "Twelfth class" });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3985));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5866), new DateTime(2024, 4, 8, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5901), new DateTime(2024, 4, 5, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5919), new DateTime(2024, 4, 6, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5929), new DateTime(2024, 4, 11, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5938), new DateTime(2024, 4, 8, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5941), new DateTime(2024, 4, 9, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(5944) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(79));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 190, DateTimeKind.Utc).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(8895), new DateTime(2024, 4, 13, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(8911), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(9263), new DateTime(2024, 4, 23, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(9274), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(9888));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(9897));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 189, DateTimeKind.Utc).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3531));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 3, 8, 29, 49, 193, DateTimeKind.Utc).AddTicks(6037));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArabicName",
                table: "EducationalClasses");

            migrationBuilder.RenameColumn(
                name: "EnglishName",
                table: "EducationalClasses",
                newName: "Name");

            migrationBuilder.AddColumn<Guid>(
                name: "CycleConditionsProvidedFormId",
                table: "ConditionAttachments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryClassification",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7112), new DateTime(2024, 5, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7117), new DateTime(2024, 4, 26, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7090), new DateTime(2024, 4, 26, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7095), new DateTime(2024, 4, 21, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7070), new DateTime(2024, 4, 21, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7075), new DateTime(2024, 4, 16, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7079) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(6984), new DateTime(2024, 4, 16, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(6990), new DateTime(2024, 4, 11, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(6939), new DateTime(2024, 4, 11, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(6952), new DateTime(2024, 4, 6, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(6969) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 928, DateTimeKind.Utc).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 928, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 928, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 928, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 928, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 928, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 928, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9583), new DateTime(2024, 4, 1, 11, 57, 58, 930, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9740), new DateTime(2024, 4, 1, 11, 57, 58, 930, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9804), new DateTime(2024, 4, 1, 11, 57, 58, 930, DateTimeKind.Local).AddTicks(9813) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9839), new DateTime(2024, 4, 1, 11, 57, 58, 930, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2049), "الصف الأول" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2061), "الصف الثاني" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2071), "الصف الثالث" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2080), "الصف الرابع" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2088), "الصف الخامس" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2096), "الصف السادس" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2106), "الصف السابع" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2115), "الصف الثامن" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2125), "الصف التاسع" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2171), "الصف العاشر" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2184), "الصف الحادي عشر" });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"),
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2194), "الصف الثاني عشر" });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9207));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9211), new DateTime(2024, 4, 6, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9250), new DateTime(2024, 4, 3, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9347), new DateTime(2024, 4, 4, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9353) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9360), new DateTime(2024, 4, 9, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9369), new DateTime(2024, 4, 6, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9372), new DateTime(2024, 4, 7, 9, 57, 58, 926, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(2365), new DateTime(2024, 4, 11, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(2379), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(2739), new DateTime(2024, 4, 21, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(2749), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3079));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 927, DateTimeKind.Utc).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(435));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 930, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 4, 1, 9, 57, 58, 931, DateTimeKind.Utc).AddTicks(1742));
        }
    }
}
