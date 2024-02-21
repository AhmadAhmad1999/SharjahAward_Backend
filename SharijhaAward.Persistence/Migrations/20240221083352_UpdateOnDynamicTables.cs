using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOnDynamicTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "StaticAttributes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "StaticAttributes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "StaticAttributes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "StaticAttributes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "DynamicAttributeValues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "DynamicAttributeValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "DynamicAttributeValues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "DynamicAttributeValues",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "DynamicAttributeSections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "DynamicAttributeSections",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "DynamicAttributeSections",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "DynamicAttributeSections",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "DynamicAttributes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "DynamicAttributes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "DynamicAttributes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "DynamicAttributes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "DynamicAttributeListValues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "DynamicAttributeListValues",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "DynamicAttributeListValues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "DynamicAttributeListValues",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "DynamicAttributeGeneralValidations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "DynamicAttributeGeneralValidations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "DynamicAttributeGeneralValidations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "DynamicAttributeGeneralValidations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "DependencyValidations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "DependencyValidations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "DependencyValidations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "DependencyValidations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "DependencyGroup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "DependencyGroup",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "DependencyGroup",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "DependencyGroup",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Dependencies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Dependencies",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Dependencies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Dependencies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AttributeTableNames",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "AttributeTableNames",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "AttributeTableNames",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "AttributeTableNames",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AttributeOperations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "AttributeOperations",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "AttributeOperations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "AttributeOperations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AttributeDataTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "AttributeDataTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "AttributeDataTypes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "AttributeDataTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "StaticAttributes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "StaticAttributes");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "StaticAttributes");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "StaticAttributes");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "StaticAttributes");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "StaticAttributes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "DynamicAttributeValues");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "DynamicAttributeValues");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "DynamicAttributeValues");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "DynamicAttributeValues");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "DynamicAttributeValues");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "DynamicAttributeValues");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "DynamicAttributeSections");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "DynamicAttributeSections");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "DynamicAttributeSections");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "DynamicAttributeSections");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "DynamicAttributeSections");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "DynamicAttributeSections");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "DynamicAttributes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "DynamicAttributes");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "DynamicAttributes");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "DynamicAttributes");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "DynamicAttributes");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "DynamicAttributes");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "DynamicAttributeListValues");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "DynamicAttributeListValues");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "DynamicAttributeListValues");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "DynamicAttributeListValues");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "DynamicAttributeListValues");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "DynamicAttributeListValues");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "DynamicAttributeGeneralValidations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "DynamicAttributeGeneralValidations");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "DynamicAttributeGeneralValidations");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "DynamicAttributeGeneralValidations");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "DynamicAttributeGeneralValidations");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "DynamicAttributeGeneralValidations");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "DependencyValidations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "DependencyValidations");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "DependencyValidations");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "DependencyValidations");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "DependencyValidations");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "DependencyValidations");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "DependencyGroup");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "DependencyGroup");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "DependencyGroup");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "DependencyGroup");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "DependencyGroup");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "DependencyGroup");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Dependencies");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Dependencies");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Dependencies");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Dependencies");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Dependencies");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Dependencies");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AttributeTableNames");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AttributeTableNames");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "AttributeTableNames");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "AttributeTableNames");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "AttributeTableNames");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "AttributeTableNames");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AttributeOperations");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AttributeOperations");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "AttributeOperations");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "AttributeOperations");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "AttributeOperations");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "AttributeOperations");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AttributeDataTypes");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AttributeDataTypes");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "AttributeDataTypes");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "AttributeDataTypes");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "AttributeDataTypes");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "AttributeDataTypes");
        }
    }
}
