using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editOnProvidedForm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAccepted",
                table: "ProvidedForms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4456), new DateTime(2024, 5, 25, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4460), new DateTime(2024, 5, 20, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4468), new DateTime(2024, 5, 30, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4472), new DateTime(2024, 5, 25, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4474), new DateTime(2024, 6, 4, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4477), new DateTime(2024, 5, 30, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4479), new DateTime(2024, 6, 9, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4480), new DateTime(2024, 6, 4, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4482), new DateTime(2024, 6, 14, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4484), new DateTime(2024, 6, 9, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4484) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6367));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4875), new DateTime(2024, 5, 15, 11, 55, 9, 724, DateTimeKind.Local).AddTicks(4881) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4893), new DateTime(2024, 5, 15, 11, 55, 9, 724, DateTimeKind.Local).AddTicks(4894) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4895), new DateTime(2024, 5, 15, 11, 55, 9, 724, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4898), new DateTime(2024, 5, 15, 11, 55, 9, 724, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(4911), new DateTime(2024, 5, 20, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(4914), new DateTime(2024, 5, 17, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(4922), new DateTime(2024, 5, 18, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(4924), new DateTime(2024, 5, 23, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(4926), new DateTime(2024, 5, 20, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(4927), new DateTime(2024, 5, 21, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(4928) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5304), new DateTime(2024, 5, 25, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5308), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5446), new DateTime(2024, 6, 4, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(5448), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 723, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsAccepted", "TotalStep" },
                values: new object[] { new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5377), false, 6 });

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 8, 55, 9, 724, DateTimeKind.Utc).AddTicks(4735));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAccepted",
                table: "ProvidedForms");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2245), new DateTime(2024, 5, 24, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2259), new DateTime(2024, 5, 19, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2283), new DateTime(2024, 5, 29, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2287), new DateTime(2024, 5, 24, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2295), new DateTime(2024, 6, 3, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2299), new DateTime(2024, 5, 29, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2302) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2305), new DateTime(2024, 6, 8, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2311), new DateTime(2024, 6, 3, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2317), new DateTime(2024, 6, 13, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2322), new DateTime(2024, 6, 8, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9340));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9561));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2944));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3764), new DateTime(2024, 5, 14, 10, 56, 48, 922, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3945), new DateTime(2024, 5, 14, 10, 56, 48, 922, DateTimeKind.Local).AddTicks(3950) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3963), new DateTime(2024, 5, 14, 10, 56, 48, 922, DateTimeKind.Local).AddTicks(3966) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3988), new DateTime(2024, 5, 14, 10, 56, 48, 922, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3547));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5604), new DateTime(2024, 5, 19, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5611), new DateTime(2024, 5, 16, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5628), new DateTime(2024, 5, 17, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5631) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5637), new DateTime(2024, 5, 22, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5641), new DateTime(2024, 5, 19, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5645), new DateTime(2024, 5, 20, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8115), new DateTime(2024, 5, 24, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8125), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8502), new DateTime(2024, 6, 3, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8512), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TotalStep" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6054), 7 });

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 923, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3165));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(3173));
        }
    }
}
