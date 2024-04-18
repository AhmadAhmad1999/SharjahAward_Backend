using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTables_ExtraAttachmentFiles_ConditionAttachments_CycleConditionAttachments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComitteesArbitrators_Arbitrators_ArbitratorId",
                table: "ComitteesArbitrators");

            migrationBuilder.AddColumn<bool>(
                name: "IsAccept",
                table: "ExtraAttachmentsProvidedForms",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReasonOfReject",
                table: "ExtraAttachmentsProvidedForms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAccept",
                table: "CycleConditionAttachments",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReasonOfReject",
                table: "CycleConditionAttachments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsAccept",
                table: "ConditionAttachments",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReasonOfReject",
                table: "ConditionAttachments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ArbitratorId",
                table: "ComitteesArbitrators",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6289), new DateTime(2024, 4, 28, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6296), new DateTime(2024, 4, 23, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6310), new DateTime(2024, 5, 3, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6314), new DateTime(2024, 4, 28, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6317), new DateTime(2024, 5, 8, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6320), new DateTime(2024, 5, 3, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6324), new DateTime(2024, 5, 13, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6326), new DateTime(2024, 5, 8, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6329), new DateTime(2024, 5, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6332), new DateTime(2024, 5, 13, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 17, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 17, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 17, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 17, DateTimeKind.Utc).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 17, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 17, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 17, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7420), new DateTime(2024, 4, 18, 16, 50, 34, 18, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7531), new DateTime(2024, 4, 18, 16, 50, 34, 18, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7539), new DateTime(2024, 4, 18, 16, 50, 34, 18, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7546), new DateTime(2024, 4, 18, 16, 50, 34, 18, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7011), new DateTime(2024, 4, 23, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7016), new DateTime(2024, 4, 20, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7029), new DateTime(2024, 4, 21, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7034), new DateTime(2024, 4, 26, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7037), new DateTime(2024, 4, 23, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7039), new DateTime(2024, 4, 24, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7859), new DateTime(2024, 4, 28, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7865) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8142), new DateTime(2024, 5, 8, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.AddForeignKey(
                name: "FK_ComitteesArbitrators_Arbitrators_ArbitratorId",
                table: "ComitteesArbitrators",
                column: "ArbitratorId",
                principalTable: "Arbitrators",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComitteesArbitrators_Arbitrators_ArbitratorId",
                table: "ComitteesArbitrators");

            migrationBuilder.DropColumn(
                name: "IsAccept",
                table: "ExtraAttachmentsProvidedForms");

            migrationBuilder.DropColumn(
                name: "ReasonOfReject",
                table: "ExtraAttachmentsProvidedForms");

            migrationBuilder.DropColumn(
                name: "IsAccept",
                table: "CycleConditionAttachments");

            migrationBuilder.DropColumn(
                name: "ReasonOfReject",
                table: "CycleConditionAttachments");

            migrationBuilder.DropColumn(
                name: "IsAccept",
                table: "ConditionAttachments");

            migrationBuilder.DropColumn(
                name: "ReasonOfReject",
                table: "ConditionAttachments");

            migrationBuilder.AlterColumn<int>(
                name: "ArbitratorId",
                table: "ComitteesArbitrators",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5010), new DateTime(2024, 4, 28, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5023), new DateTime(2024, 4, 23, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5033) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5036), new DateTime(2024, 5, 3, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5038), new DateTime(2024, 4, 28, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5040) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5042), new DateTime(2024, 5, 8, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5044), new DateTime(2024, 5, 3, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5048), new DateTime(2024, 5, 13, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5050), new DateTime(2024, 5, 8, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5054), new DateTime(2024, 5, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5056), new DateTime(2024, 5, 13, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5439));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 123, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 123, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 123, DateTimeKind.Utc).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 123, DateTimeKind.Utc).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 123, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 123, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 123, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7986));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6226), new DateTime(2024, 4, 18, 14, 49, 22, 124, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6337), new DateTime(2024, 4, 18, 14, 49, 22, 124, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6344), new DateTime(2024, 4, 18, 14, 49, 22, 124, DateTimeKind.Local).AddTicks(6346) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6350), new DateTime(2024, 4, 18, 14, 49, 22, 124, DateTimeKind.Local).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3866), new DateTime(2024, 4, 23, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3870), new DateTime(2024, 4, 20, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3881), new DateTime(2024, 4, 21, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3887), new DateTime(2024, 4, 26, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3889), new DateTime(2024, 4, 23, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3891), new DateTime(2024, 4, 24, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3892) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(4905), new DateTime(2024, 4, 28, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(4911) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5181), new DateTime(2024, 5, 8, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 122, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7799));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 12, 49, 22, 124, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.AddForeignKey(
                name: "FK_ComitteesArbitrators_Arbitrators_ArbitratorId",
                table: "ComitteesArbitrators",
                column: "ArbitratorId",
                principalTable: "Arbitrators",
                principalColumn: "Id");
        }
    }
}
