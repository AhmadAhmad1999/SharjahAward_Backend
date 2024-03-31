using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable_EducationalClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CycleClass_EducationalClass_EducationalClassId",
                table: "CycleClass");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationalClass_Users_CreatedById",
                table: "EducationalClass");

            migrationBuilder.DropForeignKey(
                name: "FK_EducationalClass_Users_UpdatedById",
                table: "EducationalClass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationalClass",
                table: "EducationalClass");

            migrationBuilder.DropIndex(
                name: "IX_EducationalClass_CreatedById",
                table: "EducationalClass");

            migrationBuilder.DropIndex(
                name: "IX_EducationalClass_UpdatedById",
                table: "EducationalClass");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "EducationalClass");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "EducationalClass");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "EducationalClass");

            migrationBuilder.RenameTable(
                name: "EducationalClass",
                newName: "EducationalClasses");

            migrationBuilder.AlterColumn<string>(
                name: "EnglishDescription",
                table: "TermsAndConditions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ArabicDescription",
                table: "TermsAndConditions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "EducationalClasses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "EducationalClasses",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "EducationalClasses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "EducationalClasses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationalClasses",
                table: "EducationalClasses",
                column: "Id");

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

            migrationBuilder.InsertData(
                table: "EducationalClasses",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"), "الصف الأول", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3089), null, null, "First class", null, null, false },
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"), "الصف الثاني", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3104), null, null, "Second class", null, null, false },
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"), "الصف الثالث", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3112), null, null, "Third class", null, null, false },
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"), "الصف الرابع", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3121), null, null, "Forth class", null, null, false },
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"), "الصف الخامس", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3129), null, null, "Fifth class", null, null, false },
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"), "الصف السادس", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3137), null, null, "Sixth class", null, null, false },
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"), "الصف السابع", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3145), null, null, "Seventh class", null, null, false },
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"), "الصف الثامن", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3156), null, null, "Eighth class", null, null, false },
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"), "الصف التاسع", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3164), null, null, "Ninth class", null, null, false },
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"), "الصف العاشر", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3173), null, null, "Tenth class", null, null, false },
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"), "الصف الحادي عشر", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3181), null, null, "Eleventh class", null, null, false },
                    { new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"), "الصف الحادي عشر", new DateTime(2024, 3, 31, 13, 15, 45, 789, DateTimeKind.Utc).AddTicks(3189), null, null, "Twelveth class", null, null, false }
                });

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
                columns: new[] { "CreatedAt", "DateOfWorkShop", "Time" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(2818), new DateTime(2024, 4, 10, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(2834), "10:00 - 12:00" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "Time" },
                values: new object[] { new DateTime(2024, 3, 31, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(3224), new DateTime(2024, 4, 20, 13, 15, 45, 786, DateTimeKind.Utc).AddTicks(3235), "2:00 - 3:00" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_CycleClass_EducationalClasses_EducationalClassId",
                table: "CycleClass",
                column: "EducationalClassId",
                principalTable: "EducationalClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CycleClass_EducationalClasses_EducationalClassId",
                table: "CycleClass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EducationalClasses",
                table: "EducationalClasses");

            migrationBuilder.DeleteData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"));

            migrationBuilder.DeleteData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"));

            migrationBuilder.DeleteData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"));

            migrationBuilder.DeleteData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"));

            migrationBuilder.DeleteData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"));

            migrationBuilder.DeleteData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"));

            migrationBuilder.DeleteData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e80d"));

            migrationBuilder.DeleteData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e81d"));

            migrationBuilder.DeleteData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e82d"));

            migrationBuilder.DeleteData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e83d"));

            migrationBuilder.DeleteData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e84d"));

            migrationBuilder.DeleteData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e85d"));

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "EducationalClasses");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "EducationalClasses");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "EducationalClasses");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "EducationalClasses");

            migrationBuilder.RenameTable(
                name: "EducationalClasses",
                newName: "EducationalClass");

            migrationBuilder.AlterColumn<string>(
                name: "EnglishDescription",
                table: "TermsAndConditions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ArabicDescription",
                table: "TermsAndConditions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "EducationalClass",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "EducationalClass",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "EducationalClass",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_EducationalClass",
                table: "EducationalClass",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(2134));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(536), new DateTime(2024, 4, 30, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(540), new DateTime(2024, 4, 25, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(518), new DateTime(2024, 4, 25, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(523), new DateTime(2024, 4, 20, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(500), new DateTime(2024, 4, 20, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(505), new DateTime(2024, 4, 15, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 4, 15, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(487), new DateTime(2024, 4, 10, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(443), new DateTime(2024, 4, 10, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(456), new DateTime(2024, 4, 5, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(468) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 758, DateTimeKind.Utc).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 758, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 758, DateTimeKind.Utc).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 758, DateTimeKind.Utc).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 758, DateTimeKind.Utc).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 758, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 758, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(2698), new DateTime(2024, 3, 31, 12, 51, 25, 760, DateTimeKind.Local).AddTicks(2710) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(2836), new DateTime(2024, 3, 31, 12, 51, 25, 760, DateTimeKind.Local).AddTicks(2845) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(2862), new DateTime(2024, 3, 31, 12, 51, 25, 760, DateTimeKind.Local).AddTicks(2869) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(2883), new DateTime(2024, 3, 31, 12, 51, 25, 760, DateTimeKind.Local).AddTicks(2890) });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 756, DateTimeKind.Utc).AddTicks(8277), new DateTime(2024, 4, 5, 10, 51, 25, 756, DateTimeKind.Utc).AddTicks(8315), new DateTime(2024, 4, 2, 10, 51, 25, 756, DateTimeKind.Utc).AddTicks(8330), new DateTime(2024, 4, 3, 10, 51, 25, 756, DateTimeKind.Utc).AddTicks(8333) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 756, DateTimeKind.Utc).AddTicks(8338), new DateTime(2024, 4, 8, 10, 51, 25, 756, DateTimeKind.Utc).AddTicks(8347), new DateTime(2024, 4, 5, 10, 51, 25, 756, DateTimeKind.Utc).AddTicks(8351), new DateTime(2024, 4, 6, 10, 51, 25, 756, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "Time" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(1503), new DateTime(2024, 4, 10, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(1518), "10:51:25.7571857" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "Time" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(1909), new DateTime(2024, 4, 20, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(1919), "10:51:25.7571929" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(3126));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.CreateIndex(
                name: "IX_EducationalClass_CreatedById",
                table: "EducationalClass",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalClass_UpdatedById",
                table: "EducationalClass",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_CycleClass_EducationalClass_EducationalClassId",
                table: "CycleClass",
                column: "EducationalClassId",
                principalTable: "EducationalClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EducationalClass_Users_CreatedById",
                table: "EducationalClass",
                column: "CreatedById",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationalClass_Users_UpdatedById",
                table: "EducationalClass",
                column: "UpdatedById",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
