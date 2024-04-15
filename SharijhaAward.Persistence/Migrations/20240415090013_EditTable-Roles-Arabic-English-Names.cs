using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTableRolesArabicEnglishNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RolePermissions_Roles_RoleId",
                table: "RolePermissions");

            migrationBuilder.DropColumn(
                name: "RoleRoleId",
                table: "RolePermissions");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "Roles",
                newName: "EnglishName");

            migrationBuilder.AddColumn<string>(
                name: "ArabicName",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "RolePermissions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PermissionHeaderId",
                table: "Permissions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PermissionHeaders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionHeaders", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5148), new DateTime(2024, 4, 25, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5157), new DateTime(2024, 4, 20, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5170), new DateTime(2024, 4, 30, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5172), new DateTime(2024, 4, 25, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5174) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5177), new DateTime(2024, 5, 5, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5179), new DateTime(2024, 4, 30, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5183), new DateTime(2024, 5, 10, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5185), new DateTime(2024, 5, 5, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5189), new DateTime(2024, 5, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5191), new DateTime(2024, 5, 10, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(313));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6414), new DateTime(2024, 4, 15, 11, 0, 9, 44, DateTimeKind.Local).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6523), new DateTime(2024, 4, 15, 11, 0, 9, 44, DateTimeKind.Local).AddTicks(6526) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6533), new DateTime(2024, 4, 15, 11, 0, 9, 44, DateTimeKind.Local).AddTicks(6535) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6541), new DateTime(2024, 4, 15, 11, 0, 9, 44, DateTimeKind.Local).AddTicks(6546) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6768), new DateTime(2024, 4, 20, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6780), new DateTime(2024, 4, 17, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6793), new DateTime(2024, 4, 18, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6799), new DateTime(2024, 4, 23, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6802), new DateTime(2024, 4, 20, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6804), new DateTime(2024, 4, 21, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 42, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9201), new DateTime(2024, 4, 25, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9206), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9515), new DateTime(2024, 5, 5, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9520), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 41, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ArabicName",
                value: "ادمن");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ArabicName",
                value: "مشترك");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ArabicName",
                value: "مدير");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "ArabicName",
                value: "مستخدم");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "ArabicName",
                value: "منسق");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "ArabicName",
                value: "محكم");

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 9, 0, 9, 44, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PermissionHeaderId",
                table: "Permissions",
                column: "PermissionHeaderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Permissions_PermissionHeaders_PermissionHeaderId",
                table: "Permissions",
                column: "PermissionHeaderId",
                principalTable: "PermissionHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermissions_Roles_RoleId",
                table: "RolePermissions",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Permissions_PermissionHeaders_PermissionHeaderId",
                table: "Permissions");

            migrationBuilder.DropForeignKey(
                name: "FK_RolePermissions_Roles_RoleId",
                table: "RolePermissions");

            migrationBuilder.DropTable(
                name: "PermissionHeaders");

            migrationBuilder.DropIndex(
                name: "IX_Permissions_PermissionHeaderId",
                table: "Permissions");

            migrationBuilder.DropColumn(
                name: "ArabicName",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "PermissionHeaderId",
                table: "Permissions");

            migrationBuilder.RenameColumn(
                name: "EnglishName",
                table: "Roles",
                newName: "RoleName");

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "RolePermissions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "RoleRoleId",
                table: "RolePermissions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(101), new DateTime(2024, 4, 24, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(106), new DateTime(2024, 4, 19, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(117) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(120), new DateTime(2024, 4, 29, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(122), new DateTime(2024, 4, 24, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(125), new DateTime(2024, 5, 4, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(127), new DateTime(2024, 4, 29, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(128) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(130), new DateTime(2024, 5, 9, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(133), new DateTime(2024, 5, 4, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(134) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(136), new DateTime(2024, 5, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(138), new DateTime(2024, 5, 9, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(139) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 635, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 635, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 635, DateTimeKind.Utc).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 635, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(9905));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1030), new DateTime(2024, 4, 14, 13, 58, 54, 636, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1137), new DateTime(2024, 4, 14, 13, 58, 54, 636, DateTimeKind.Local).AddTicks(1138) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1142), new DateTime(2024, 4, 14, 13, 58, 54, 636, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1148), new DateTime(2024, 4, 14, 13, 58, 54, 636, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2796), new DateTime(2024, 4, 19, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2804), new DateTime(2024, 4, 16, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2816), new DateTime(2024, 4, 17, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2820), new DateTime(2024, 4, 22, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2823), new DateTime(2024, 4, 19, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2824), new DateTime(2024, 4, 20, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4868));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4875));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4205), new DateTime(2024, 4, 24, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4210), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4455), new DateTime(2024, 5, 4, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4458), "Saturday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 634, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 14, 11, 58, 54, 636, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.AddForeignKey(
                name: "FK_RolePermissions_Roles_RoleId",
                table: "RolePermissions",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id");
        }
    }
}
