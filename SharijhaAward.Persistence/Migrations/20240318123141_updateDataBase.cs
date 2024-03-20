using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class updateDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GeneralFrequentlyAskedQuestions_GeneralFrequentlyAskedQuestionCategories_GeneralFrequentlyAskedQuestionCategoryId",
                table: "GeneralFrequentlyAskedQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneralFrequentlyAskedQuestions",
                table: "GeneralFrequentlyAskedQuestions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneralFrequentlyAskedQuestionCategories",
                table: "GeneralFrequentlyAskedQuestionCategories");

            migrationBuilder.RenameTable(
                name: "GeneralFrequentlyAskedQuestions",
                newName: "GeneralFrequentlyAskedQuestion");

            migrationBuilder.RenameTable(
                name: "GeneralFrequentlyAskedQuestionCategories",
                newName: "GeneralFrequentlyAskedQuestionCategory");

            migrationBuilder.RenameIndex(
                name: "IX_GeneralFrequentlyAskedQuestions_GeneralFrequentlyAskedQuestionCategoryId",
                table: "GeneralFrequentlyAskedQuestion",
                newName: "IX_GeneralFrequentlyAskedQuestion_GeneralFrequentlyAskedQuestionCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneralFrequentlyAskedQuestion",
                table: "GeneralFrequentlyAskedQuestion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneralFrequentlyAskedQuestionCategory",
                table: "GeneralFrequentlyAskedQuestionCategory",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(8732), new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(8734), new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(8736), new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(8737), new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(8709), new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(8715), new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(8721), new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(8723), new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9252));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9172));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9176));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9185));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestion",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(5926));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestion",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestion",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestion",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestionCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestionCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 595, DateTimeKind.Utc).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 31, 36, 596, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralFrequentlyAskedQuestion_GeneralFrequentlyAskedQuestionCategory_GeneralFrequentlyAskedQuestionCategoryId",
                table: "GeneralFrequentlyAskedQuestion",
                column: "GeneralFrequentlyAskedQuestionCategoryId",
                principalTable: "GeneralFrequentlyAskedQuestionCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GeneralFrequentlyAskedQuestion_GeneralFrequentlyAskedQuestionCategory_GeneralFrequentlyAskedQuestionCategoryId",
                table: "GeneralFrequentlyAskedQuestion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneralFrequentlyAskedQuestionCategory",
                table: "GeneralFrequentlyAskedQuestionCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GeneralFrequentlyAskedQuestion",
                table: "GeneralFrequentlyAskedQuestion");

            migrationBuilder.RenameTable(
                name: "GeneralFrequentlyAskedQuestionCategory",
                newName: "GeneralFrequentlyAskedQuestionCategories");

            migrationBuilder.RenameTable(
                name: "GeneralFrequentlyAskedQuestion",
                newName: "GeneralFrequentlyAskedQuestions");

            migrationBuilder.RenameIndex(
                name: "IX_GeneralFrequentlyAskedQuestion_GeneralFrequentlyAskedQuestionCategoryId",
                table: "GeneralFrequentlyAskedQuestions",
                newName: "IX_GeneralFrequentlyAskedQuestions_GeneralFrequentlyAskedQuestionCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneralFrequentlyAskedQuestionCategories",
                table: "GeneralFrequentlyAskedQuestionCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GeneralFrequentlyAskedQuestions",
                table: "GeneralFrequentlyAskedQuestions",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8553));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(5755), new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(5756), new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(5758), new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(5759), new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(5733), new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(5738), new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(5744), new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(5745), new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(5748) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(42));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 114, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 114, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 114, DateTimeKind.Utc).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestionCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestionCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(7956));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 113, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 27, 9, 115, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.AddForeignKey(
                name: "FK_GeneralFrequentlyAskedQuestions_GeneralFrequentlyAskedQuestionCategories_GeneralFrequentlyAskedQuestionCategoryId",
                table: "GeneralFrequentlyAskedQuestions",
                column: "GeneralFrequentlyAskedQuestionCategoryId",
                principalTable: "GeneralFrequentlyAskedQuestionCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
