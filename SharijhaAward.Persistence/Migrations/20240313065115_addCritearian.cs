using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addCritearian : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConditionAttachments_Attachments_ConditionsProvidedFormsId",
                table: "ConditionAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Criterion_ArbitrationProcedure_ArbitrationProcedureId",
                table: "Criterion");

            migrationBuilder.DropForeignKey(
                name: "FK_Criterion_Categories_CategoryId",
                table: "Criterion");

            migrationBuilder.DropForeignKey(
                name: "FK_Criterion_Criterion_ParentId",
                table: "Criterion");

            migrationBuilder.DropForeignKey(
                name: "FK_Criterion_users_CreatedById",
                table: "Criterion");

            migrationBuilder.DropForeignKey(
                name: "FK_Criterion_users_UpdatedById",
                table: "Criterion");

            migrationBuilder.DropForeignKey(
                name: "FK_CriterionItem_Criterion_CriterionId",
                table: "CriterionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CriterionItem_users_CreatedById",
                table: "CriterionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CriterionItem_users_UpdatedById",
                table: "CriterionItem");

            migrationBuilder.DropForeignKey(
                name: "FK_criterionItemScales_CriterionItem_CriterionItemsId",
                table: "criterionItemScales");

            migrationBuilder.DropForeignKey(
                name: "FK_criterionItemScales_Scale_ScalesId",
                table: "criterionItemScales");

            migrationBuilder.DropForeignKey(
                name: "FK_criterionItemScales_users_CreatedById",
                table: "criterionItemScales");

            migrationBuilder.DropForeignKey(
                name: "FK_criterionItemScales_users_UpdatedById",
                table: "criterionItemScales");

            migrationBuilder.DropForeignKey(
                name: "FK_Scale_Criterion_CriterionId",
                table: "Scale");

            migrationBuilder.DropForeignKey(
                name: "FK_Scale_users_CreatedById",
                table: "Scale");

            migrationBuilder.DropForeignKey(
                name: "FK_Scale_users_UpdatedById",
                table: "Scale");

            migrationBuilder.DropTable(
                name: "CriterionItemScale");

            migrationBuilder.DropIndex(
                name: "IX_Scale_CreatedById",
                table: "Scale");

            migrationBuilder.DropIndex(
                name: "IX_Scale_UpdatedById",
                table: "Scale");

            migrationBuilder.DropIndex(
                name: "IX_criterionItemScales_CriterionItemsId",
                table: "criterionItemScales");

            migrationBuilder.DropIndex(
                name: "IX_criterionItemScales_ScalesId",
                table: "criterionItemScales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CriterionItem",
                table: "CriterionItem");

            migrationBuilder.DropIndex(
                name: "IX_CriterionItem_CreatedById",
                table: "CriterionItem");

            migrationBuilder.DropIndex(
                name: "IX_CriterionItem_UpdatedById",
                table: "CriterionItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Criterion",
                table: "Criterion");

            migrationBuilder.DropIndex(
                name: "IX_Criterion_CreatedById",
                table: "Criterion");

            migrationBuilder.DropIndex(
                name: "IX_Criterion_UpdatedById",
                table: "Criterion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConditionAttachments",
                table: "ConditionAttachments");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Scale");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Scale");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Scale");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "criterionItemScales");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "CriterionItem");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "CriterionItem");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "CriterionItem");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Criterion");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Criterion");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "Criterion");

            migrationBuilder.RenameTable(
                name: "CriterionItem",
                newName: "CriterionItems");

            migrationBuilder.RenameTable(
                name: "Criterion",
                newName: "Criterions");

            migrationBuilder.RenameTable(
                name: "ConditionAttachments",
                newName: "ConditionAttachment");

            migrationBuilder.RenameColumn(
                name: "UpdatedById",
                table: "criterionItemScales",
                newName: "ScaleId");

            migrationBuilder.RenameColumn(
                name: "CreatedById",
                table: "criterionItemScales",
                newName: "CriterionItemId");

            migrationBuilder.RenameIndex(
                name: "IX_criterionItemScales_UpdatedById",
                table: "criterionItemScales",
                newName: "IX_criterionItemScales_ScaleId");

            migrationBuilder.RenameIndex(
                name: "IX_criterionItemScales_CreatedById",
                table: "criterionItemScales",
                newName: "IX_criterionItemScales_CriterionItemId");

            migrationBuilder.RenameIndex(
                name: "IX_CriterionItem_CriterionId",
                table: "CriterionItems",
                newName: "IX_CriterionItems_CriterionId");

            migrationBuilder.RenameIndex(
                name: "IX_Criterion_ParentId",
                table: "Criterions",
                newName: "IX_Criterions_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Criterion_CategoryId",
                table: "Criterions",
                newName: "IX_Criterions_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Criterion_ArbitrationProcedureId",
                table: "Criterions",
                newName: "IX_Criterions_ArbitrationProcedureId");

            migrationBuilder.RenameIndex(
                name: "IX_ConditionAttachments_ConditionsProvidedFormsId",
                table: "ConditionAttachment",
                newName: "IX_ConditionAttachment_ConditionsProvidedFormsId");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Scale",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Scale",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Scale",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Scale",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "criterionItemScales",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "criterionItemScales",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "criterionItemScales",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "criterionItemScales",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CriterionItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "CriterionItems",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "CriterionItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ScaleId",
                table: "CriterionItems",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "CriterionItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<Guid>(
                name: "ParentId",
                table: "Criterions",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ArbitrationProcedureId",
                table: "Criterions",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Criterions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Criterions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Criterions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Criterions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CriterionItems",
                table: "CriterionItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Criterions",
                table: "Criterions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConditionAttachment",
                table: "ConditionAttachment",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CriterionAttachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachementPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: false),
                    CriterionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriterionAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriterionAttachments_Criterions_CriterionId",
                        column: x => x.CriterionId,
                        principalTable: "Criterions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CriterionItemAttachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachementPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SizeOfAttachmentInKB = table.Column<int>(type: "int", nullable: false),
                    CriterionItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriterionItemAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CriterionItemAttachments_CriterionItems_CriterionItemId",
                        column: x => x.CriterionItemId,
                        principalTable: "CriterionItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(8250), new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(8253), new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(8255), new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(8257), new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(8258) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(8198), new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(8206), new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(8214), new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(8218), new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(8222) });

            migrationBuilder.InsertData(
                table: "Criterions",
                columns: new[] { "Id", "ArabicTitle", "ArbitrationProcedureId", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "ParentId", "Score", "isDeleted" },
                values: new object[] { new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"), "معيار رئيسي 1", null, new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"), new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(7662), null, null, "Main Criterion 1", null, null, null, 100, false });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(9235));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(9118));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(9139));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 6, 51, 10, 677, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.InsertData(
                table: "Criterions",
                columns: new[] { "Id", "ArabicTitle", "ArbitrationProcedureId", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "ParentId", "Score", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"), "معيار فرعي 2", null, new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"), new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(7677), null, null, "Sub Criterion 2", null, null, new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"), 50, false },
                    { new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"), "معيار فرعي 1", null, new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"), new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(7671), null, null, "Sub Criterion 1", null, null, new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"), 50, false }
                });

            migrationBuilder.InsertData(
                table: "CriterionItems",
                columns: new[] { "Id", "ActualScore", "ArabicName", "CreatedAt", "CreatedBy", "CriterionId", "DeletedAt", "EnglishName", "LastModifiedAt", "LastModifiedBy", "ScaleId", "Score", "isDeleted" },
                values: new object[,]
                {
                    { new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"), 0, "بند معيار فرعي 22", new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(7804), null, new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"), null, "Sub Criterion Item 22", null, null, null, 50, false },
                    { new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"), 0, "بند معيار فرعي 21", new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(7800), null, new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"), null, "Sub Criterion Item 21", null, null, null, 50, false },
                    { new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"), 0, "بند معيار فرعي 11", new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(7789), null, new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"), null, "Sub Criterion Item 11", null, null, null, 50, false },
                    { new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"), 0, "بند معيار فرعي 12", new DateTime(2024, 3, 13, 6, 51, 10, 676, DateTimeKind.Utc).AddTicks(7795), null, new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"), null, "Sub Criterion Item 12", null, null, null, 50, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItems_ScaleId",
                table: "CriterionItems",
                column: "ScaleId");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionAttachments_CriterionId",
                table: "CriterionAttachments",
                column: "CriterionId");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItemAttachments_CriterionItemId",
                table: "CriterionItemAttachments",
                column: "CriterionItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionAttachment_Attachments_ConditionsProvidedFormsId",
                table: "ConditionAttachment",
                column: "ConditionsProvidedFormsId",
                principalTable: "Attachments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CriterionItems_Criterions_CriterionId",
                table: "CriterionItems",
                column: "CriterionId",
                principalTable: "Criterions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CriterionItems_Scale_ScaleId",
                table: "CriterionItems",
                column: "ScaleId",
                principalTable: "Scale",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_criterionItemScales_CriterionItems_CriterionItemId",
                table: "criterionItemScales",
                column: "CriterionItemId",
                principalTable: "CriterionItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_criterionItemScales_Scale_ScaleId",
                table: "criterionItemScales",
                column: "ScaleId",
                principalTable: "Scale",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Criterions_ArbitrationProcedure_ArbitrationProcedureId",
                table: "Criterions",
                column: "ArbitrationProcedureId",
                principalTable: "ArbitrationProcedure",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Criterions_Categories_CategoryId",
                table: "Criterions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Criterions_Criterions_ParentId",
                table: "Criterions",
                column: "ParentId",
                principalTable: "Criterions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scale_Criterions_CriterionId",
                table: "Scale",
                column: "CriterionId",
                principalTable: "Criterions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConditionAttachment_Attachments_ConditionsProvidedFormsId",
                table: "ConditionAttachment");

            migrationBuilder.DropForeignKey(
                name: "FK_CriterionItems_Criterions_CriterionId",
                table: "CriterionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CriterionItems_Scale_ScaleId",
                table: "CriterionItems");

            migrationBuilder.DropForeignKey(
                name: "FK_criterionItemScales_CriterionItems_CriterionItemId",
                table: "criterionItemScales");

            migrationBuilder.DropForeignKey(
                name: "FK_criterionItemScales_Scale_ScaleId",
                table: "criterionItemScales");

            migrationBuilder.DropForeignKey(
                name: "FK_Criterions_ArbitrationProcedure_ArbitrationProcedureId",
                table: "Criterions");

            migrationBuilder.DropForeignKey(
                name: "FK_Criterions_Categories_CategoryId",
                table: "Criterions");

            migrationBuilder.DropForeignKey(
                name: "FK_Criterions_Criterions_ParentId",
                table: "Criterions");

            migrationBuilder.DropForeignKey(
                name: "FK_Scale_Criterions_CriterionId",
                table: "Scale");

            migrationBuilder.DropTable(
                name: "CriterionAttachments");

            migrationBuilder.DropTable(
                name: "CriterionItemAttachments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Criterions",
                table: "Criterions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CriterionItems",
                table: "CriterionItems");

            migrationBuilder.DropIndex(
                name: "IX_CriterionItems_ScaleId",
                table: "CriterionItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConditionAttachment",
                table: "ConditionAttachment");

            migrationBuilder.DeleteData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"));

            migrationBuilder.DeleteData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"));

            migrationBuilder.DeleteData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"));

            migrationBuilder.DeleteData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"));

            migrationBuilder.DeleteData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"));

            migrationBuilder.DeleteData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"));

            migrationBuilder.DeleteData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"));

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Scale");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Scale");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Scale");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Scale");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "criterionItemScales");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "criterionItemScales");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "criterionItemScales");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "criterionItemScales");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Criterions");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Criterions");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Criterions");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Criterions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CriterionItems");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "CriterionItems");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "CriterionItems");

            migrationBuilder.DropColumn(
                name: "ScaleId",
                table: "CriterionItems");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "CriterionItems");

            migrationBuilder.RenameTable(
                name: "Criterions",
                newName: "Criterion");

            migrationBuilder.RenameTable(
                name: "CriterionItems",
                newName: "CriterionItem");

            migrationBuilder.RenameTable(
                name: "ConditionAttachment",
                newName: "ConditionAttachments");

            migrationBuilder.RenameColumn(
                name: "ScaleId",
                table: "criterionItemScales",
                newName: "UpdatedById");

            migrationBuilder.RenameColumn(
                name: "CriterionItemId",
                table: "criterionItemScales",
                newName: "CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_criterionItemScales_ScaleId",
                table: "criterionItemScales",
                newName: "IX_criterionItemScales_UpdatedById");

            migrationBuilder.RenameIndex(
                name: "IX_criterionItemScales_CriterionItemId",
                table: "criterionItemScales",
                newName: "IX_criterionItemScales_CreatedById");

            migrationBuilder.RenameIndex(
                name: "IX_Criterions_ParentId",
                table: "Criterion",
                newName: "IX_Criterion_ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Criterions_CategoryId",
                table: "Criterion",
                newName: "IX_Criterion_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Criterions_ArbitrationProcedureId",
                table: "Criterion",
                newName: "IX_Criterion_ArbitrationProcedureId");

            migrationBuilder.RenameIndex(
                name: "IX_CriterionItems_CriterionId",
                table: "CriterionItem",
                newName: "IX_CriterionItem_CriterionId");

            migrationBuilder.RenameIndex(
                name: "IX_ConditionAttachment_ConditionsProvidedFormsId",
                table: "ConditionAttachments",
                newName: "IX_ConditionAttachments_ConditionsProvidedFormsId");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "Scale",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Scale",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "Scale",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "criterionItemScales",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<Guid>(
                name: "ParentId",
                table: "Criterion",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ArbitrationProcedureId",
                table: "Criterion",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "Criterion",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Criterion",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "Criterion",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "CriterionItem",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "CriterionItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "CriterionItem",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Criterion",
                table: "Criterion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CriterionItem",
                table: "CriterionItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConditionAttachments",
                table: "ConditionAttachments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CriterionItemScale",
                columns: table => new
                {
                    CriterionItemsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScalesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CriterionItemScale", x => new { x.CriterionItemsId, x.ScalesId });
                    table.ForeignKey(
                        name: "FK_CriterionItemScale_CriterionItem_CriterionItemsId",
                        column: x => x.CriterionItemsId,
                        principalTable: "CriterionItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CriterionItemScale_Scale_ScalesId",
                        column: x => x.ScalesId,
                        principalTable: "Scale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1667));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 27, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1121), new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1123), new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1125), new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1126), new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1104), new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1108), new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1113), new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1114), new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 12, 25, 1, 28, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.CreateIndex(
                name: "IX_Scale_CreatedById",
                table: "Scale",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Scale_UpdatedById",
                table: "Scale",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_criterionItemScales_CriterionItemsId",
                table: "criterionItemScales",
                column: "CriterionItemsId");

            migrationBuilder.CreateIndex(
                name: "IX_criterionItemScales_ScalesId",
                table: "criterionItemScales",
                column: "ScalesId");

            migrationBuilder.CreateIndex(
                name: "IX_Criterion_CreatedById",
                table: "Criterion",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Criterion_UpdatedById",
                table: "Criterion",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItem_CreatedById",
                table: "CriterionItem",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItem_UpdatedById",
                table: "CriterionItem",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItemScale_ScalesId",
                table: "CriterionItemScale",
                column: "ScalesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionAttachments_Attachments_ConditionsProvidedFormsId",
                table: "ConditionAttachments",
                column: "ConditionsProvidedFormsId",
                principalTable: "Attachments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Criterion_ArbitrationProcedure_ArbitrationProcedureId",
                table: "Criterion",
                column: "ArbitrationProcedureId",
                principalTable: "ArbitrationProcedure",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Criterion_Categories_CategoryId",
                table: "Criterion",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Criterion_Criterion_ParentId",
                table: "Criterion",
                column: "ParentId",
                principalTable: "Criterion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Criterion_users_CreatedById",
                table: "Criterion",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Criterion_users_UpdatedById",
                table: "Criterion",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CriterionItem_Criterion_CriterionId",
                table: "CriterionItem",
                column: "CriterionId",
                principalTable: "Criterion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CriterionItem_users_CreatedById",
                table: "CriterionItem",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CriterionItem_users_UpdatedById",
                table: "CriterionItem",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_criterionItemScales_CriterionItem_CriterionItemsId",
                table: "criterionItemScales",
                column: "CriterionItemsId",
                principalTable: "CriterionItem",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_criterionItemScales_Scale_ScalesId",
                table: "criterionItemScales",
                column: "ScalesId",
                principalTable: "Scale",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_criterionItemScales_users_CreatedById",
                table: "criterionItemScales",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_criterionItemScales_users_UpdatedById",
                table: "criterionItemScales",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scale_Criterion_CriterionId",
                table: "Scale",
                column: "CriterionId",
                principalTable: "Criterion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Scale_users_CreatedById",
                table: "Scale",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Scale_users_UpdatedById",
                table: "Scale",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");
        }
    }
}
