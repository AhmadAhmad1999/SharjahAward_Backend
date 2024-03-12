using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addCoordinatorTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_conditionAttachments_Attachments_ConditionsProvidedFormsId",
                table: "conditionAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_cycleCondition_cycles_CycleId",
                table: "cycleCondition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cycleCondition",
                table: "cycleCondition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_conditionAttachments",
                table: "conditionAttachments");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "DynamicAttributes");

            migrationBuilder.RenameTable(
                name: "cycleCondition",
                newName: "CycleCondition");

            migrationBuilder.RenameTable(
                name: "conditionAttachments",
                newName: "ConditionAttachments");

            migrationBuilder.RenameIndex(
                name: "IX_cycleCondition_CycleId",
                table: "CycleCondition",
                newName: "IX_CycleCondition_CycleId");

            migrationBuilder.RenameIndex(
                name: "IX_conditionAttachments_ConditionsProvidedFormsId",
                table: "ConditionAttachments",
                newName: "IX_ConditionAttachments_ConditionsProvidedFormsId");



            migrationBuilder.AddPrimaryKey(
                name: "PK_CycleCondition",
                table: "CycleCondition",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConditionAttachments",
                table: "ConditionAttachments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Coordinators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationType = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coordinators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationalInstitutions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_EducationalInstitutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationalEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationalInstitutionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationalEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationalEntities_EducationalInstitutions_EducationalInstitutionId",
                        column: x => x.EducationalInstitutionId,
                        principalTable: "EducationalInstitutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationCoordinators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoordinatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EducationalEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationCoordinators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationCoordinators_Coordinators_CoordinatorId",
                        column: x => x.CoordinatorId,
                        principalTable: "Coordinators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationCoordinators_EducationalEntities_EducationalEntityId",
                        column: x => x.EducationalEntityId,
                        principalTable: "EducationalEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7456), "ProvidedForm" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ArabicDescription", "ArabicName", "CategoryClassification", "CreatedAt", "CreatedBy", "CycleId", "DeletedAt", "EnglishDescription", "EnglishName", "ExpectedNumberOfWinners", "FinalArbitrationEndDate", "FinalArbitrationQualificationMark", "FinalArbitrationStartDate", "Icon", "InitialArbitrationEndDate", "InitialArbitrationStartDate", "LastModifiedAt", "LastModifiedBy", "ParentId", "RelatedToClasses", "Status", "SubscriberPortalClosingDate", "WinningScore", "isDeleted" },
                values: new object[] { new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"), "اختبار وصف 1", "اختبار اسم 1", 0, new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4268), null, new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"), null, "Test Description 1", "Test Name 1", 1, new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4271), 0, new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4276), "string", null, new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4278), null, null, null, false, 0, new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4281), 0, false });

          

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "ArabicName", "CreatedAt", "CreatedBy", "DeletedAt", "Email", "EnglishName", "Gender", "LastModifiedAt", "LastModifiedBy", "Password", "RoleId", "isDeleted" },
                values: new object[] { new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"), "ادمن 123", new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4431), null, null, "ahmad.a.ahmad.100011@gmail.com", "Admin 123", 0, null, null, "QAZwsx!@1212", new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"), false });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ArabicDescription", "ArabicName", "CategoryClassification", "CreatedAt", "CreatedBy", "CycleId", "DeletedAt", "EnglishDescription", "EnglishName", "ExpectedNumberOfWinners", "FinalArbitrationEndDate", "FinalArbitrationQualificationMark", "FinalArbitrationStartDate", "Icon", "InitialArbitrationEndDate", "InitialArbitrationStartDate", "LastModifiedAt", "LastModifiedBy", "ParentId", "RelatedToClasses", "Status", "SubscriberPortalClosingDate", "WinningScore", "isDeleted" },
                values: new object[] { new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"), "اختبار وصف 2", "اختبار اسم 2", 0, new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4287), null, new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"), null, "Test Description 2", "Test Name 2", 1, new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4289), 0, new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4290), "string", null, new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4291), null, null, new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"), false, 0, new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4292), 0, false });

           

            


            migrationBuilder.CreateIndex(
                name: "IX_EducationalEntities_EducationalInstitutionId",
                table: "EducationalEntities",
                column: "EducationalInstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationCoordinators_CoordinatorId",
                table: "EducationCoordinators",
                column: "CoordinatorId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationCoordinators_EducationalEntityId",
                table: "EducationCoordinators",
                column: "EducationalEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionAttachments_Attachments_ConditionsProvidedFormsId",
                table: "ConditionAttachments",
                column: "ConditionsProvidedFormsId",
                principalTable: "Attachments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CycleCondition_cycles_CycleId",
                table: "CycleCondition",
                column: "CycleId",
                principalTable: "cycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConditionAttachments_Attachments_ConditionsProvidedFormsId",
                table: "ConditionAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_CycleCondition_cycles_CycleId",
                table: "CycleCondition");

            migrationBuilder.DropTable(
                name: "EducationCoordinators");

            migrationBuilder.DropTable(
                name: "Coordinators");

            migrationBuilder.DropTable(
                name: "EducationalEntities");

            migrationBuilder.DropTable(
                name: "EducationalInstitutions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CycleCondition",
                table: "CycleCondition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConditionAttachments",
                table: "ConditionAttachments");

            migrationBuilder.DeleteData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"));

            migrationBuilder.DeleteData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"));

            migrationBuilder.DeleteData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "CycleCondition",
                newName: "cycleCondition");

            migrationBuilder.RenameTable(
                name: "ConditionAttachments",
                newName: "conditionAttachments");

            migrationBuilder.RenameIndex(
                name: "IX_CycleCondition_CycleId",
                table: "cycleCondition",
                newName: "IX_cycleCondition_CycleId");

            migrationBuilder.RenameIndex(
                name: "IX_ConditionAttachments_ConditionsProvidedFormsId",
                table: "conditionAttachments",
                newName: "IX_conditionAttachments_ConditionsProvidedFormsId");

            migrationBuilder.AlterColumn<Guid>(
                name: "RecordId",
                table: "DynamicAttributeValues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "DynamicAttributes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cycleCondition",
                table: "cycleCondition",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_conditionAttachments",
                table: "conditionAttachments",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EducationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 3, 11, 8, 26, 18, 667, DateTimeKind.Utc).AddTicks(7224), "Category" });

            migrationBuilder.AddForeignKey(
                name: "FK_conditionAttachments_Attachments_ConditionsProvidedFormsId",
                table: "conditionAttachments",
                column: "ConditionsProvidedFormsId",
                principalTable: "Attachments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cycleCondition_cycles_CycleId",
                table: "cycleCondition",
                column: "CycleId",
                principalTable: "cycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
