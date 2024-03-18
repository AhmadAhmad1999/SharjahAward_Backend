using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOnGeneralWorkShop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            

            migrationBuilder.AddColumn<string>(
                name: "AgendaImage",
                table: "GeneralWorkshops",
                type: "nvarchar(max)",
                nullable: true);

           

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(1957), new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(1959), new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(1961), new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(1962), new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(1909), new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(1939), new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(1945), new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(1947), new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(4801));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 780, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2443));

           

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 10, 42, 38, 781, DateTimeKind.Utc).AddTicks(2250));

            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
          

            migrationBuilder.DropColumn(
                name: "AgendaImage",
                table: "GeneralWorkshops");



            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5323), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5325), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5326), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5327), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5296), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5299), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5304), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5317), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5692));

           

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.AddForeignKey(
                name: "FK_OurGoal_AboutAwardPage_AboutAwardPageId",
                table: "OurGoals",
                column: "AboutAwardPageId",
                principalTable: "AboutAwardPage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
