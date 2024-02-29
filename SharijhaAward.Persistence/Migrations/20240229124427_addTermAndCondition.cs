using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addTermAndCondition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CycleCondition_users_CreatedById",
                table: "CycleCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_CycleCondition_users_UpdatedById",
                table: "CycleCondition");

            migrationBuilder.DropForeignKey(
                name: "FK_TermsAndConditions_users_CreatedById",
                table: "TermsAndConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_TermsAndConditions_users_UpdatedById",
                table: "TermsAndConditions");

            migrationBuilder.DropIndex(
                name: "IX_TermsAndConditions_CreatedById",
                table: "TermsAndConditions");

            migrationBuilder.DropIndex(
                name: "IX_TermsAndConditions_UpdatedById",
                table: "TermsAndConditions");

            migrationBuilder.DropIndex(
                name: "IX_CycleCondition_CreatedById",
                table: "CycleCondition");

            migrationBuilder.DropIndex(
                name: "IX_CycleCondition_UpdatedById",
                table: "CycleCondition");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "TermsAndConditions");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "TermsAndConditions");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "TermsAndConditions");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "CycleCondition");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "CycleCondition");

            migrationBuilder.DropColumn(
                name: "UpdatedById",
                table: "CycleCondition");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "TermsAndConditions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "TermsAndConditions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "TermsAndConditions",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CycleCondition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "CycleCondition",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "CycleCondition",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TermsAndConditions");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "TermsAndConditions");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "TermsAndConditions");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "TermsAndConditions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CycleCondition");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "CycleCondition");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "CycleCondition");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "CycleCondition");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "TermsAndConditions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "TermsAndConditions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "TermsAndConditions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedById",
                table: "CycleCondition",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "CycleCondition",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "UpdatedById",
                table: "CycleCondition",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_TermsAndConditions_CreatedById",
                table: "TermsAndConditions",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_TermsAndConditions_UpdatedById",
                table: "TermsAndConditions",
                column: "UpdatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CycleCondition_CreatedById",
                table: "CycleCondition",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_CycleCondition_UpdatedById",
                table: "CycleCondition",
                column: "UpdatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_CycleCondition_users_CreatedById",
                table: "CycleCondition",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CycleCondition_users_UpdatedById",
                table: "CycleCondition",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TermsAndConditions_users_CreatedById",
                table: "TermsAndConditions",
                column: "CreatedById",
                principalTable: "users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TermsAndConditions_users_UpdatedById",
                table: "TermsAndConditions",
                column: "UpdatedById",
                principalTable: "users",
                principalColumn: "Id");
        }
    }
}
