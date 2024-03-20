using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class DeleteAchevment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4311));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(7923), new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(7925), new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(7926), new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(7927), new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(7903), new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(7908), new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(7914), new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(7915), new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8424));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestionCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestionCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "GeneralFrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 648, DateTimeKind.Utc).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 12, 7, 48, 649, DateTimeKind.Utc).AddTicks(8182));
        }
    }
}
