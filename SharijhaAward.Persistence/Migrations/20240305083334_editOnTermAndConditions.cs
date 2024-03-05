using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editOnTermAndConditions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_frequentlyAskedQuestions_Categories_CategoryId",
                table: "frequentlyAskedQuestions");



            migrationBuilder.DropColumn(
                name: "Type",
                table: "Attachments");

            migrationBuilder.AlterColumn<int>(
                name: "RequiredAttachmentNumber",
                table: "TermsAndConditions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsAgree",
                table: "TermsAndConditions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SizeOfAttachmentInKB",
                table: "TermsAndConditions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "TermsAndConditions",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "frequentlyAskedQuestions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 5, 8, 33, 28, 681, DateTimeKind.Utc).AddTicks(9578));

            migrationBuilder.AddForeignKey(
                name: "FK_frequentlyAskedQuestions_Categories_CategoryId",
                table: "frequentlyAskedQuestions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_frequentlyAskedQuestions_Categories_CategoryId",
                table: "frequentlyAskedQuestions");

            migrationBuilder.DropColumn(
                name: "IsAgree",
                table: "TermsAndConditions");

            migrationBuilder.DropColumn(
                name: "SizeOfAttachmentInKB",
                table: "TermsAndConditions");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "TermsAndConditions");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Attachments");

            migrationBuilder.AlterColumn<int>(
                name: "RequiredAttachmentNumber",
                table: "TermsAndConditions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "frequentlyAskedQuestions",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "CycleId",
                table: "frequentlyAskedQuestions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Attachments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 4, 13, 54, 26, 220, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.CreateIndex(
                name: "IX_frequentlyAskedQuestions_CycleId",
                table: "frequentlyAskedQuestions",
                column: "CycleId");

            migrationBuilder.AddForeignKey(
                name: "FK_frequentlyAskedQuestions_Categories_CategoryId",
                table: "frequentlyAskedQuestions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_frequentlyAskedQuestions_cycles_CycleId",
                table: "frequentlyAskedQuestions",
                column: "CycleId",
                principalTable: "cycles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
