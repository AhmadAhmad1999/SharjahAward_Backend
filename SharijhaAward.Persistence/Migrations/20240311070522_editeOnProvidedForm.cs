using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editeOnProvidedForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachementPath",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Attachments");

            migrationBuilder.RenameColumn(
                name: "SizeOfAttachmentInKB",
                table: "Attachments",
                newName: "ProvidedFormId");

            migrationBuilder.AddColumn<bool>(
                name: "IsAgree",
                table: "Attachments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 11, 7, 5, 18, 56, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_ProvidedFormId",
                table: "Attachments",
                column: "ProvidedFormId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_ProvidedForms_ProvidedFormId",
                table: "Attachments",
                column: "ProvidedFormId",
                principalTable: "ProvidedForms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_ProvidedForms_ProvidedFormId",
                table: "Attachments");

            migrationBuilder.DropIndex(
                name: "IX_Attachments_ProvidedFormId",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "IsAgree",
                table: "Attachments");

            migrationBuilder.RenameColumn(
                name: "ProvidedFormId",
                table: "Attachments",
                newName: "SizeOfAttachmentInKB");

            migrationBuilder.AddColumn<string>(
                name: "AttachementPath",
                table: "Attachments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Attachments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Attachments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 10, 10, 44, 3, 447, DateTimeKind.Utc).AddTicks(333));
        }
    }
}
