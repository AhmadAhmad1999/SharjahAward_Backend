using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable_CycleAttachmentsConditions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConditionAttachments_Attachments_ConditionsProvidedFormsId",
                table: "ConditionAttachments");

            migrationBuilder.AddColumn<string>(
                name: "ArabicDescription",
                table: "CycleCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AttachmentType",
                table: "CycleCondition",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnglishDescription",
                table: "CycleCondition",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsAgree",
                table: "CycleCondition",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "NeedAttachment",
                table: "CycleCondition",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "RequiredAttachmentNumber",
                table: "CycleCondition",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SizeOfAttachmentInKB",
                table: "CycleCondition",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ConditionsProvidedFormsId",
                table: "ConditionAttachments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "CycleConditionsProvidedFormId",
                table: "ConditionAttachments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CurrentDate",
                table: "Agendas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CycleConditionsProvidedForms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsAgree = table.Column<bool>(type: "bit", nullable: false),
                    CycleConditionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CycleConditionsProvidedForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CycleConditionsProvidedForms_CycleCondition_CycleConditionId",
                        column: x => x.CycleConditionId,
                        principalTable: "CycleCondition",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CycleConditionsProvidedForms_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CycleConditionAttachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachementPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: false),
                    CycleConditionsProvidedFormId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CycleConditionAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CycleConditionAttachments_CycleConditionsProvidedForms_CycleConditionsProvidedFormId",
                        column: x => x.CycleConditionsProvidedFormId,
                        principalTable: "CycleConditionsProvidedForms",
                        principalColumn: "Id");
                });

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
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(536), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 30, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(540), new DateTime(2024, 4, 25, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(543) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(518), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 25, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(523), new DateTime(2024, 4, 20, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(526) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(500), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 20, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(505), new DateTime(2024, 4, 15, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(482), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 15, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(487), new DateTime(2024, 4, 10, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(443), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(456), new DateTime(2024, 4, 5, 10, 51, 25, 760, DateTimeKind.Utc).AddTicks(468) });

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
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName", "Time" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(1503), new DateTime(2024, 4, 10, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(1518), "Wednesday", "10:51:25.7571857" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName", "Time" },
                values: new object[] { new DateTime(2024, 3, 31, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(1909), new DateTime(2024, 4, 20, 10, 51, 25, 757, DateTimeKind.Utc).AddTicks(1919), "Saturday", "10:51:25.7571929" });

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
                name: "IX_ConditionAttachments_CycleConditionsProvidedFormId",
                table: "ConditionAttachments",
                column: "CycleConditionsProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_CycleConditionAttachments_CycleConditionsProvidedFormId",
                table: "CycleConditionAttachments",
                column: "CycleConditionsProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_CycleConditionsProvidedForms_CycleConditionId",
                table: "CycleConditionsProvidedForms",
                column: "CycleConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_CycleConditionsProvidedForms_ProvidedFormId",
                table: "CycleConditionsProvidedForms",
                column: "ProvidedFormId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionAttachments_Attachments_ConditionsProvidedFormsId",
                table: "ConditionAttachments",
                column: "ConditionsProvidedFormsId",
                principalTable: "Attachments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionAttachments_CycleConditionsProvidedForms_CycleConditionsProvidedFormId",
                table: "ConditionAttachments",
                column: "CycleConditionsProvidedFormId",
                principalTable: "CycleConditionsProvidedForms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConditionAttachments_Attachments_ConditionsProvidedFormsId",
                table: "ConditionAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionAttachments_CycleConditionsProvidedForms_CycleConditionsProvidedFormId",
                table: "ConditionAttachments");

            migrationBuilder.DropTable(
                name: "CycleConditionAttachments");

            migrationBuilder.DropTable(
                name: "CycleConditionsProvidedForms");

            migrationBuilder.DropIndex(
                name: "IX_ConditionAttachments_CycleConditionsProvidedFormId",
                table: "ConditionAttachments");

            migrationBuilder.DropColumn(
                name: "ArabicDescription",
                table: "CycleCondition");

            migrationBuilder.DropColumn(
                name: "AttachmentType",
                table: "CycleCondition");

            migrationBuilder.DropColumn(
                name: "EnglishDescription",
                table: "CycleCondition");

            migrationBuilder.DropColumn(
                name: "IsAgree",
                table: "CycleCondition");

            migrationBuilder.DropColumn(
                name: "NeedAttachment",
                table: "CycleCondition");

            migrationBuilder.DropColumn(
                name: "RequiredAttachmentNumber",
                table: "CycleCondition");

            migrationBuilder.DropColumn(
                name: "SizeOfAttachmentInKB",
                table: "CycleCondition");

            migrationBuilder.DropColumn(
                name: "CycleConditionsProvidedFormId",
                table: "ConditionAttachments");

            migrationBuilder.AlterColumn<Guid>(
                name: "ConditionsProvidedFormsId",
                table: "ConditionAttachments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Agendas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Agendas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CurrentDate",
                table: "Agendas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6293), null, new DateTime(2024, 4, 27, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6298), new DateTime(2024, 4, 22, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6275), null, new DateTime(2024, 4, 22, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6280), new DateTime(2024, 4, 17, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6258), null, new DateTime(2024, 4, 17, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6262), new DateTime(2024, 4, 12, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6237), null, new DateTime(2024, 4, 12, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6242), new DateTime(2024, 4, 7, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6195), null, new DateTime(2024, 4, 7, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6208), new DateTime(2024, 4, 2, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 566, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 566, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 566, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 566, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 566, DateTimeKind.Utc).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 566, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 566, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8706), new DateTime(2024, 3, 28, 16, 7, 22, 568, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8874), new DateTime(2024, 3, 28, 16, 7, 22, 568, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8901), new DateTime(2024, 3, 28, 16, 7, 22, 568, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8928), new DateTime(2024, 3, 28, 16, 7, 22, 568, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8259));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3764), new DateTime(2024, 4, 2, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3807), new DateTime(2024, 3, 30, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3821), new DateTime(2024, 3, 31, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3830), new DateTime(2024, 4, 5, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3839), new DateTime(2024, 4, 2, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3842), new DateTime(2024, 4, 3, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName", "Time" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(6954), new DateTime(2024, 4, 7, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(6969), "Sunday", "14:07:22.5657294" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName", "Time" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(7350), new DateTime(2024, 4, 17, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(7360), "Wednesday", "14:07:22.5657371" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(919));

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionAttachments_Attachments_ConditionsProvidedFormsId",
                table: "ConditionAttachments",
                column: "ConditionsProvidedFormsId",
                principalTable: "Attachments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
