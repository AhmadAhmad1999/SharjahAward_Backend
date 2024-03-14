using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditOnProvidedFormTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "FinalScore",
                table: "ProvidedForms",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "SubscriberType",
                table: "ProvidedForms",
                type: "int",
                nullable: false,
                defaultValue: 0);

           
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalScore",
                table: "ProvidedForms");

            migrationBuilder.DropColumn(
                name: "SubscriberType",
                table: "ProvidedForms");

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 48, DateTimeKind.Utc).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(2982), new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(2984), new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(2986), new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(2987), new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(2988) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(2929), new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(2960), new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(2969), new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(2971), new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 49, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 49, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 49, DateTimeKind.Utc).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 49, DateTimeKind.Utc).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 49, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 49, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 49, DateTimeKind.Utc).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3580));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3607));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3611));

            

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 7, 33, 26, 50, DateTimeKind.Utc).AddTicks(3350));
        }
    }
}
