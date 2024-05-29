using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditOnAgenda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPrivate",
                table: "Agendas",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "IsPrivate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3516), new DateTime(2024, 6, 6, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3519), false, new DateTime(2024, 6, 1, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "IsPrivate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3524), new DateTime(2024, 6, 11, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3526), false, new DateTime(2024, 6, 6, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3527) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "IsPrivate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3528), new DateTime(2024, 6, 16, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3529), false, new DateTime(2024, 6, 11, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "IsPrivate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3532), new DateTime(2024, 6, 21, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3534), false, new DateTime(2024, 6, 16, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "IsPrivate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3536), new DateTime(2024, 6, 26, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3537), false, new DateTime(2024, 6, 21, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6490));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6497));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5505));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4854));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5361));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5363));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4776));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3817), new DateTime(2024, 5, 27, 11, 49, 43, 620, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3841), new DateTime(2024, 5, 27, 11, 49, 43, 620, DateTimeKind.Local).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3843), new DateTime(2024, 5, 27, 11, 49, 43, 620, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3845), new DateTime(2024, 5, 27, 11, 49, 43, 620, DateTimeKind.Local).AddTicks(3847) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4194));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3739));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5772), new DateTime(2024, 6, 1, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5775), new DateTime(2024, 5, 29, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5782), new DateTime(2024, 5, 30, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5783) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5784), new DateTime(2024, 6, 4, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5786), new DateTime(2024, 6, 1, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5787), new DateTime(2024, 6, 2, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5788) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6195), new DateTime(2024, 6, 6, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6199), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6334), new DateTime(2024, 6, 16, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(6335), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4593));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4671));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4677));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5110));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4471));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5383));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 619, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4238));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 27, 8, 49, 43, 620, DateTimeKind.Utc).AddTicks(3699));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPrivate",
                table: "Agendas");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(975), new DateTime(2024, 6, 5, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(985), new DateTime(2024, 5, 31, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1009) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1014), new DateTime(2024, 6, 10, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1018), new DateTime(2024, 6, 5, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1025), new DateTime(2024, 6, 15, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1029), new DateTime(2024, 6, 10, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1032) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1036), new DateTime(2024, 6, 20, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1040), new DateTime(2024, 6, 15, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1043) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1047), new DateTime(2024, 6, 25, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1051), new DateTime(2024, 6, 20, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4898));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1760));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9402));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9409));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(9221));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5501));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2508), new DateTime(2024, 5, 26, 15, 7, 57, 408, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2694), new DateTime(2024, 5, 26, 15, 7, 57, 408, DateTimeKind.Local).AddTicks(2698) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2737), new DateTime(2024, 5, 26, 15, 7, 57, 408, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2754), new DateTime(2024, 5, 26, 15, 7, 57, 408, DateTimeKind.Local).AddTicks(2757) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4409));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2002), new DateTime(2024, 5, 31, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2010), new DateTime(2024, 5, 28, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2032), new DateTime(2024, 5, 29, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2035) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2041), new DateTime(2024, 6, 3, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2047), new DateTime(2024, 5, 31, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2051), new DateTime(2024, 6, 1, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(3776), new DateTime(2024, 6, 5, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(3787), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4179), new DateTime(2024, 6, 15, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(4185), "Saturday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6574));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(5814));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 404, DateTimeKind.Utc).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 409, DateTimeKind.Utc).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(3980));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 12, 7, 57, 408, DateTimeKind.Utc).AddTicks(2043));
        }
    }
}
