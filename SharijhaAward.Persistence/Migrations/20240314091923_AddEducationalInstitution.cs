using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddEducationalInstitution : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "EducationalInstitutions",
                newName: "EnglishName");

            migrationBuilder.AddColumn<string>(
                name: "ArabicName",
                table: "EducationalInstitutions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "EducationalEntityId",
                table: "EducationalInstitutions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "InstitutionCoordinators",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CoordinatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_InstitutionCoordinators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstitutionCoordinators_Coordinators_CoordinatorId",
                        column: x => x.CoordinatorId,
                        principalTable: "Coordinators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstitutionCoordinators_EducationalInstitutions_EducationalInstitutionId",
                        column: x => x.EducationalInstitutionId,
                        principalTable: "EducationalInstitutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6899), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6901), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6902), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6903), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6871), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6874), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6879), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6892), new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(6894) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7237));

           

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 9, 19, 20, 48, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.CreateIndex(
                name: "IX_EducationalInstitutions_EducationalEntityId",
                table: "EducationalInstitutions",
                column: "EducationalEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionCoordinators_CoordinatorId",
                table: "InstitutionCoordinators",
                column: "CoordinatorId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionCoordinators_EducationalInstitutionId",
                table: "InstitutionCoordinators",
                column: "EducationalInstitutionId");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationalInstitutions_EducationalEntities_EducationalEntityId",
                table: "EducationalInstitutions",
                column: "EducationalEntityId",
                principalTable: "EducationalEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationalInstitutions_EducationalEntities_EducationalEntityId",
                table: "EducationalInstitutions");

            migrationBuilder.DropTable(
                name: "InstitutionCoordinators");

            migrationBuilder.DropIndex(
                name: "IX_EducationalInstitutions_EducationalEntityId",
                table: "EducationalInstitutions");

            migrationBuilder.DropColumn(
                name: "ArabicName",
                table: "EducationalInstitutions");

            migrationBuilder.DropColumn(
                name: "EducationalEntityId",
                table: "EducationalInstitutions");

            migrationBuilder.RenameColumn(
                name: "EnglishName",
                table: "EducationalInstitutions",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(3853), new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(3855), new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(3857), new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(3858), new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(3859) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(3824), new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(3827), new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(3832), new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(3847), new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(3849) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(9432));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(9429));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 74, DateTimeKind.Utc).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4242));

            

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 34, 14, 75, DateTimeKind.Utc).AddTicks(4075));
        }
    }
}
