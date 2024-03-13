using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editeOnProvidedForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "TotalStep",
                table: "ProvidedForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 972, DateTimeKind.Utc).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2547), new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2549), new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2550), new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2551), new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2527), new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2534), new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2539), new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2541), new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2543) });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TotalStep" },
                values: new object[] { new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2786), 7 });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 13, 9, 49, 11, 973, DateTimeKind.Utc).AddTicks(2753));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalStep",
                table: "ProvidedForms");

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
        }
    }
}
