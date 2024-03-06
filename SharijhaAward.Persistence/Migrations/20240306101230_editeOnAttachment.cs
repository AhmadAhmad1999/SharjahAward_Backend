using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editeOnAttachment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CycleCondition_cycles_CycleId",
                table: "CycleCondition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CycleCondition",
                table: "CycleCondition");

            migrationBuilder.DeleteData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.RenameTable(
                name: "CycleCondition",
                newName: "cycleCondition");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "TermsAndConditions",
                newName: "AttachmentType");

            migrationBuilder.RenameIndex(
                name: "IX_CycleCondition_CycleId",
                table: "cycleCondition",
                newName: "IX_cycleCondition_CycleId");

            migrationBuilder.RenameColumn(
                name: "Attached",
                table: "Attachments",
                newName: "AttachementPath");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "DynamicAttributeGeneralValidations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cycleCondition",
                table: "cycleCondition",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9078));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9079), "Number" });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9081), "Date" });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9083), "List" });

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(8860), "Category" });

            migrationBuilder.AddForeignKey(
                name: "FK_cycleCondition_cycles_CycleId",
                table: "cycleCondition",
                column: "CycleId",
                principalTable: "cycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cycleCondition_cycles_CycleId",
                table: "cycleCondition");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cycleCondition",
                table: "cycleCondition");

            migrationBuilder.RenameTable(
                name: "cycleCondition",
                newName: "CycleCondition");

            migrationBuilder.RenameColumn(
                name: "AttachmentType",
                table: "TermsAndConditions",
                newName: "Type");

            migrationBuilder.RenameIndex(
                name: "IX_cycleCondition_CycleId",
                table: "CycleCondition",
                newName: "IX_CycleCondition_CycleId");

            migrationBuilder.RenameColumn(
                name: "AttachementPath",
                table: "Attachments",
                newName: "Attached");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "DynamicAttributeGeneralValidations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CycleCondition",
                table: "CycleCondition",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2165), "Phone Number" });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2167), "Number" });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2169), "Date" });

            migrationBuilder.InsertData(
                table: "AttributeDataTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "isDeleted" },
                values: new object[,]
                {
                    { 9, new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2170), null, null, null, null, "Single Select List", false },
                    { 10, new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2245), null, null, null, null, "Multi Select List", false }
                });

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2308));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 3, 5, 13, 11, 31, 902, DateTimeKind.Utc).AddTicks(1946), "SubCategory" });

            migrationBuilder.AddForeignKey(
                name: "FK_CycleCondition_cycles_CycleId",
                table: "CycleCondition",
                column: "CycleId",
                principalTable: "cycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
