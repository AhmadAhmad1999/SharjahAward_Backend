using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editeOnAttachments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArabicWorkshopAttachment",
                table: "trainingWorkshops");

            migrationBuilder.DropColumn(
                name: "EnglishWorkshopAttachment",
                table: "trainingWorkshops");

            migrationBuilder.RenameColumn(
                name: "EnglishFile",
                table: "explanatoryGuides",
                newName: "EnglishTitle");

            migrationBuilder.RenameColumn(
                name: "ArabicFile",
                table: "explanatoryGuides",
                newName: "EnglishFilePath");

            migrationBuilder.AddColumn<Guid>(
                name: "TrainingWorkshopId",
                table: "trainingWorkshops",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ArabicFilePath",
                table: "explanatoryGuides",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArabicTitle",
                table: "explanatoryGuides",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 19, 56, 50, 493, DateTimeKind.Utc).AddTicks(1698));

            migrationBuilder.CreateIndex(
                name: "IX_trainingWorkshops_TrainingWorkshopId",
                table: "trainingWorkshops",
                column: "TrainingWorkshopId");

            migrationBuilder.AddForeignKey(
                name: "FK_trainingWorkshops_trainingWorkshops_TrainingWorkshopId",
                table: "trainingWorkshops",
                column: "TrainingWorkshopId",
                principalTable: "trainingWorkshops",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trainingWorkshops_trainingWorkshops_TrainingWorkshopId",
                table: "trainingWorkshops");

            migrationBuilder.DropIndex(
                name: "IX_trainingWorkshops_TrainingWorkshopId",
                table: "trainingWorkshops");

            migrationBuilder.DropColumn(
                name: "TrainingWorkshopId",
                table: "trainingWorkshops");

            migrationBuilder.DropColumn(
                name: "ArabicFilePath",
                table: "explanatoryGuides");

            migrationBuilder.DropColumn(
                name: "ArabicTitle",
                table: "explanatoryGuides");

            migrationBuilder.RenameColumn(
                name: "EnglishTitle",
                table: "explanatoryGuides",
                newName: "EnglishFile");

            migrationBuilder.RenameColumn(
                name: "EnglishFilePath",
                table: "explanatoryGuides",
                newName: "ArabicFile");

            migrationBuilder.AddColumn<string>(
                name: "ArabicWorkshopAttachment",
                table: "trainingWorkshops",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EnglishWorkshopAttachment",
                table: "trainingWorkshops",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(9083));

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
                column: "CreatedAt",
                value: new DateTime(2024, 3, 6, 10, 12, 24, 435, DateTimeKind.Utc).AddTicks(8860));
        }
    }
}
