using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editeOnCoordinator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
       

          

            migrationBuilder.AddColumn<int>(
                name: "Emirates",
                table: "Coordinators",
                type: "int",
                nullable: false,
                defaultValue: 0);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Emirates",
                table: "Coordinators");

            migrationBuilder.AddColumn<Guid>(
                name: "EducationalInstitutionId",
                table: "EducationalEntities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 202, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4287), new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4289), new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4290), new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4291), new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4268), new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4271), new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4276), new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4278), new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4513));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 8, 49, 25, 203, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.CreateIndex(
                name: "IX_EducationalEntities_EducationalInstitutionId",
                table: "EducationalEntities",
                column: "EducationalInstitutionId");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationalEntities_EducationalInstitutions_EducationalInstitutionId",
                table: "EducationalEntities",
                column: "EducationalInstitutionId",
                principalTable: "EducationalInstitutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
