using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_ProvidedForms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryEducationalEntityId",
                table: "ProvidedForms",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(3856), new DateTime(2024, 6, 19, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(3865), new DateTime(2024, 6, 14, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(3885), new DateTime(2024, 6, 24, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(3888), new DateTime(2024, 6, 19, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(3891), new DateTime(2024, 6, 29, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(3893), new DateTime(2024, 6, 24, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(3897), new DateTime(2024, 7, 4, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(3900), new DateTime(2024, 6, 29, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(3903), new DateTime(2024, 7, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(3906), new DateTime(2024, 7, 4, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8934));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3715));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3742));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6153));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4666), new DateTime(2024, 6, 9, 16, 56, 43, 851, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4808), new DateTime(2024, 6, 9, 16, 56, 43, 851, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4825), new DateTime(2024, 6, 9, 16, 56, 43, 851, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4833), new DateTime(2024, 6, 9, 16, 56, 43, 851, DateTimeKind.Local).AddTicks(4835) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(986), new DateTime(2024, 6, 14, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(992), new DateTime(2024, 6, 11, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(1009), new DateTime(2024, 6, 12, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(1011) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(1014), new DateTime(2024, 6, 17, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(1018), new DateTime(2024, 6, 14, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(1022), new DateTime(2024, 6, 15, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(1023) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9283));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9290));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(2818), new DateTime(2024, 6, 19, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(2825) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 9, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3141), new DateTime(2024, 6, 29, 13, 56, 43, 848, DateTimeKind.Utc).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6871));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7012));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6613));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6620));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 847, DateTimeKind.Utc).AddTicks(9820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 847, DateTimeKind.Utc).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 847, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 847, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 847, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9177));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 13, 56, 43, 851, DateTimeKind.Utc).AddTicks(4388));

            migrationBuilder.CreateIndex(
                name: "IX_ProvidedForms_CategoryEducationalEntityId",
                table: "ProvidedForms",
                column: "CategoryEducationalEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProvidedForms_CategoryEducationalEntities_CategoryEducationalEntityId",
                table: "ProvidedForms",
                column: "CategoryEducationalEntityId",
                principalTable: "CategoryEducationalEntities",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProvidedForms_CategoryEducationalEntities_CategoryEducationalEntityId",
                table: "ProvidedForms");

            migrationBuilder.DropIndex(
                name: "IX_ProvidedForms_CategoryEducationalEntityId",
                table: "ProvidedForms");

            migrationBuilder.DropColumn(
                name: "CategoryEducationalEntityId",
                table: "ProvidedForms");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(2720), new DateTime(2024, 6, 19, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(2731), new DateTime(2024, 6, 14, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(2746), new DateTime(2024, 6, 24, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(2748), new DateTime(2024, 6, 19, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(2752), new DateTime(2024, 6, 29, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(2754), new DateTime(2024, 6, 24, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(2776), new DateTime(2024, 7, 4, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(2778), new DateTime(2024, 6, 29, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(2782), new DateTime(2024, 7, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(2786), new DateTime(2024, 7, 4, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(2787) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3129));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8057));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5493));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3532), new DateTime(2024, 6, 9, 14, 38, 6, 422, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3657), new DateTime(2024, 6, 9, 14, 38, 6, 422, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3674), new DateTime(2024, 6, 9, 14, 38, 6, 422, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3681), new DateTime(2024, 6, 9, 14, 38, 6, 422, DateTimeKind.Local).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(6611), new DateTime(2024, 6, 14, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(6616), new DateTime(2024, 6, 11, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(6629), new DateTime(2024, 6, 12, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(6631) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(6634), new DateTime(2024, 6, 17, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(6637), new DateTime(2024, 6, 14, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(6639), new DateTime(2024, 6, 15, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7677));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(7631), new DateTime(2024, 6, 19, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(7637) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(7887), new DateTime(2024, 6, 29, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(7890) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6033));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6094));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6100));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5717));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(5900));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 419, DateTimeKind.Utc).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(3270));
        }
    }
}
