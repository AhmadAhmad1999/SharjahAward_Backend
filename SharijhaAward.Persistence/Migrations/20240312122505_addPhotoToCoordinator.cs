using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addPhotoToCoordinator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PersonalPhoto",
                table: "Coordinators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RoleId",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"));

            migrationBuilder.DropColumn(
                name: "PersonalPhoto",
                table: "Coordinators");

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8684));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 78, DateTimeKind.Utc).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7386), new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7387), new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7389), new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7390), new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7391) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7365), new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7369), new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7375), new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7377), new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7380) });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 12, 11, 33, 27, 79, DateTimeKind.Utc).AddTicks(7577));
        }
    }
}
