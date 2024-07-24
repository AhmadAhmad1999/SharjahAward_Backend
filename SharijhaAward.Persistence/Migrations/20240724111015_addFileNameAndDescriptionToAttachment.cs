using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addFileNameAndDescriptionToAttachment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileDescription",
                table: "ExtraAttachmentsProvidedForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "ExtraAttachmentsProvidedForms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5607), new DateTime(2024, 7, 30, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5622), new DateTime(2024, 8, 3, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5620), new DateTime(2024, 7, 29, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5623), new DateTime(2024, 8, 5, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5627), new DateTime(2024, 8, 9, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5625), new DateTime(2024, 8, 4, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5626) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5628), new DateTime(2024, 8, 11, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5631), new DateTime(2024, 8, 15, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5630), new DateTime(2024, 8, 10, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5633), new DateTime(2024, 8, 17, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5636), new DateTime(2024, 8, 21, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5634), new DateTime(2024, 8, 16, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5635) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5637), new DateTime(2024, 8, 23, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5640), new DateTime(2024, 8, 27, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5638), new DateTime(2024, 8, 22, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5968));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6669), new DateTime(2024, 7, 29, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6672), new DateTime(2024, 7, 26, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6683), new DateTime(2024, 7, 27, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6684) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6686), new DateTime(2024, 8, 1, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6688), new DateTime(2024, 7, 29, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6689), new DateTime(2024, 7, 30, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7095), new DateTime(2024, 8, 3, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7098), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7269), new DateTime(2024, 8, 13, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(7271), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6778));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6799));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6823));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6837));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7329));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6096));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6132));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6146));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 270, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 24, 11, 10, 10, 271, DateTimeKind.Utc).AddTicks(5873));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileDescription",
                table: "ExtraAttachmentsProvidedForms");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "ExtraAttachmentsProvidedForms");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(464), new DateTime(2024, 7, 28, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(473), new DateTime(2024, 8, 1, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(472), new DateTime(2024, 7, 27, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(469) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(476), new DateTime(2024, 8, 3, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(479), new DateTime(2024, 8, 7, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(478), new DateTime(2024, 8, 2, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(481), new DateTime(2024, 8, 9, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(483), new DateTime(2024, 8, 13, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(482), new DateTime(2024, 8, 8, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(484), new DateTime(2024, 8, 15, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(487), new DateTime(2024, 8, 19, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(486), new DateTime(2024, 8, 14, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(488), new DateTime(2024, 8, 21, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(515), new DateTime(2024, 8, 25, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(513), new DateTime(2024, 8, 20, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2919));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2922));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(933));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(961), new DateTime(2024, 7, 27, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(964), new DateTime(2024, 7, 24, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(972), new DateTime(2024, 7, 25, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(973) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(974), new DateTime(2024, 7, 30, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(976), new DateTime(2024, 7, 27, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(977), new DateTime(2024, 7, 28, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(978) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2935));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2373));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2176), new DateTime(2024, 8, 1, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2182), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2232), new DateTime(2024, 8, 11, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(2235), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2361));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1803));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 912, DateTimeKind.Utc).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 912, DateTimeKind.Utc).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 912, DateTimeKind.Utc).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 912, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 912, DateTimeKind.Utc).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 913, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(852));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 22, 13, 58, 53, 914, DateTimeKind.Utc).AddTicks(855));
        }
    }
}
