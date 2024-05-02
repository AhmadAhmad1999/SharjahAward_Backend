using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_DynamicAttributeSections_AddNewColumn_OrderId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_ProvidedForms_ProvidedFormId",
                table: "Attachments");

            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_TermsAndConditions_TermAndConditionId",
                table: "Attachments");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionAttachments_Attachments_ConditionsProvidedFormsId",
                table: "ConditionAttachments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attachments",
                table: "Attachments");

            migrationBuilder.DeleteData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "IsSpecial",
                table: "TermsAndConditions");

            migrationBuilder.RenameTable(
                name: "Attachments",
                newName: "ConditionsProvidedForms");

            migrationBuilder.RenameIndex(
                name: "IX_Attachments_TermAndConditionId",
                table: "ConditionsProvidedForms",
                newName: "IX_ConditionsProvidedForms_TermAndConditionId");

            migrationBuilder.RenameIndex(
                name: "IX_Attachments_ProvidedFormId",
                table: "ConditionsProvidedForms",
                newName: "IX_ConditionsProvidedForms_ProvidedFormId");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "DynamicAttributeSections",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConditionsProvidedForms",
                table: "ConditionsProvidedForms",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4505), new DateTime(2024, 5, 12, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4515), new DateTime(2024, 5, 7, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4904), new DateTime(2024, 5, 17, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4907), new DateTime(2024, 5, 12, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4911), new DateTime(2024, 5, 22, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4914), new DateTime(2024, 5, 17, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4917), new DateTime(2024, 5, 27, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4920), new DateTime(2024, 5, 22, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4923), new DateTime(2024, 6, 1, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4925), new DateTime(2024, 5, 27, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.InsertData(
                table: "AttributeDataTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "isDeleted" },
                values: new object[] { 10, new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5560), null, null, null, null, "Emirates ID number", false });

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 424, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 424, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 424, DateTimeKind.Utc).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 424, DateTimeKind.Utc).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 424, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 424, DateTimeKind.Utc).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 424, DateTimeKind.Utc).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7726), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6310), new DateTime(2024, 5, 2, 14, 28, 51, 425, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6416), new DateTime(2024, 5, 2, 14, 28, 51, 425, DateTimeKind.Local).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6423), new DateTime(2024, 5, 2, 14, 28, 51, 425, DateTimeKind.Local).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6433), new DateTime(2024, 5, 2, 14, 28, 51, 425, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2428), new DateTime(2024, 5, 7, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2433), new DateTime(2024, 5, 4, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2444), new DateTime(2024, 5, 5, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2450), new DateTime(2024, 5, 10, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2453), new DateTime(2024, 5, 7, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2455), new DateTime(2024, 5, 8, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(3899), new DateTime(2024, 5, 12, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4169), new DateTime(2024, 5, 22, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionAttachments_ConditionsProvidedForms_ConditionsProvidedFormsId",
                table: "ConditionAttachments",
                column: "ConditionsProvidedFormsId",
                principalTable: "ConditionsProvidedForms",
                principalColumn: "Id");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConditionAttachments_ConditionsProvidedForms_ConditionsProvidedFormsId",
                table: "ConditionAttachments");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionsProvidedForms_ProvidedForms_ProvidedFormId",
                table: "ConditionsProvidedForms");

            migrationBuilder.DropForeignKey(
                name: "FK_ConditionsProvidedForms_TermsAndConditions_TermAndConditionId",
                table: "ConditionsProvidedForms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConditionsProvidedForms",
                table: "ConditionsProvidedForms");

            migrationBuilder.DeleteData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "DynamicAttributeSections");

            migrationBuilder.RenameTable(
                name: "ConditionsProvidedForms",
                newName: "Attachments");

            migrationBuilder.RenameIndex(
                name: "IX_ConditionsProvidedForms_TermAndConditionId",
                table: "Attachments",
                newName: "IX_Attachments_TermAndConditionId");

            migrationBuilder.RenameIndex(
                name: "IX_ConditionsProvidedForms_ProvidedFormId",
                table: "Attachments",
                newName: "IX_Attachments_ProvidedFormId");

            migrationBuilder.AddColumn<bool>(
                name: "IsSpecial",
                table: "TermsAndConditions",
                type: "bit",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attachments",
                table: "Attachments",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3373), new DateTime(2024, 5, 12, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3382), new DateTime(2024, 5, 7, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3395), new DateTime(2024, 5, 17, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3398), new DateTime(2024, 5, 12, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3402), new DateTime(2024, 5, 22, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3405), new DateTime(2024, 5, 17, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3408), new DateTime(2024, 5, 27, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3411), new DateTime(2024, 5, 22, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3415), new DateTime(2024, 6, 1, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3417), new DateTime(2024, 5, 27, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 21, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 21, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 21, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 21, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 21, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 21, DateTimeKind.Utc).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 21, DateTimeKind.Utc).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 5, 2, 11, 11, 35, 22, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4638), new DateTime(2024, 5, 2, 11, 11, 35, 22, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4646), new DateTime(2024, 5, 2, 11, 11, 35, 22, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4653), new DateTime(2024, 5, 2, 11, 11, 35, 22, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3974), new DateTime(2024, 5, 7, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3978), new DateTime(2024, 5, 4, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3988), new DateTime(2024, 5, 5, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3992), new DateTime(2024, 5, 10, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3996), new DateTime(2024, 5, 7, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3998), new DateTime(2024, 5, 8, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(4983), new DateTime(2024, 5, 12, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5226), new DateTime(2024, 5, 22, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsSpecial" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4856), true });

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsSpecial" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4880), true });

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsSpecial" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4885), true });

            migrationBuilder.InsertData(
                table: "TermsAndConditions",
                columns: new[] { "Id", "ArabicDescription", "ArabicTitle", "AttachmentType", "CategoryId", "CreatedAt", "CreatedBy", "DeletedAt", "EnglishDescription", "EnglishTitle", "IsAgree", "IsSpecial", "LastModifiedAt", "LastModifiedBy", "NeedAttachment", "RequiredAttachmentNumber", "SizeOfAttachmentInKB", "isDeleted" },
                values: new object[,]
                {
                    { 2, "الموافقة على سياسة الخصوصية لهذه الفئة", "الموافقة على سياسة الخصوصة", 0, 2, new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4869), null, null, "Accept on Privacy Term", "Accept on Privacy Term", false, false, null, null, false, 0, 0, false },
                    { 3, "الهوية الشخصية", "رفع صورة الهوية الشخصية (الامامي و الخلفي)", 0, 2, new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4874), null, null, "Id Card", "Upload Photos of Id Card (Front and Back)", false, false, null, null, true, 2, 1000, false },
                    { 6, "رفع الاثباتات العلمية", "رفع الاثباتات العلمية", 1, 2, new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4889), null, null, "Upload Confirmation Documents", "Upload Confirmation Documents", false, false, null, null, true, 0, 1000, false }
                });

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_ProvidedForms_ProvidedFormId",
                table: "Attachments",
                column: "ProvidedFormId",
                principalTable: "ProvidedForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_TermsAndConditions_TermAndConditionId",
                table: "Attachments",
                column: "TermAndConditionId",
                principalTable: "TermsAndConditions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConditionAttachments_Attachments_ConditionsProvidedFormsId",
                table: "ConditionAttachments",
                column: "ConditionsProvidedFormsId",
                principalTable: "Attachments",
                principalColumn: "Id");
        }
    }
}
