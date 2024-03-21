using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editeOnAgendaAddDateType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DateType",
                table: "Agenda",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8111));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(4999), new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5001), new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5003), new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5004), new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(4977), new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(4980), new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(4988), new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(4990), new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(4993) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestionCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestionCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "PrivacyPolicies",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "TermsOfUses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 767, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 21, 9, 2, 19, 768, DateTimeKind.Utc).AddTicks(5221));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateType",
                table: "Agenda");

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
    }
}
