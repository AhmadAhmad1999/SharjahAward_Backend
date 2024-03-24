using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editeOnAgenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Agenda",
                newName: "StartDate");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Agenda",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 908, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 908, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 908, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 908, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 908, DateTimeKind.Utc).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 908, DateTimeKind.Utc).AddTicks(47));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 908, DateTimeKind.Utc).AddTicks(50));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 908, DateTimeKind.Utc).AddTicks(52));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4111), new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4113), new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4115), new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4116), new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4118) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4085), new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4092), new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4099), new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4101), new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 908, DateTimeKind.Utc).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 908, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 908, DateTimeKind.Utc).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 908, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 908, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 908, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 908, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestionCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestionCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9655));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "PrivacyPolicies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "TermsOfUses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 907, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 7, 9, 0, 909, DateTimeKind.Utc).AddTicks(4452));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Agenda");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "Agenda",
                newName: "Date");

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3175), new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3177), new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3178), new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3179), new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3105), new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3109), new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3114), new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3116), new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3118) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3637));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestionCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestionCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4268));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "PrivacyPolicies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "TermsOfUses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 338, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 20, 12, 15, 41, 339, DateTimeKind.Utc).AddTicks(3464));
        }
    }
}
