using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_FinalArbitration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FinalArbitrations_Arbitrations_ArbitrationId",
                table: "FinalArbitrations");

            migrationBuilder.DeleteData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "ArbitrationId",
                table: "FinalArbitrations",
                newName: "ProvidedFormId");

            migrationBuilder.RenameIndex(
                name: "IX_FinalArbitrations_ArbitrationId",
                table: "FinalArbitrations",
                newName: "IX_FinalArbitrations_ProvidedFormId");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAccepted",
                table: "ProvidedForms",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "isAcceptedFromChairman",
                table: "FinalArbitrations",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<float>(
                name: "FinalScore",
                table: "FinalArbitrations",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ParentId",
                table: "FinalArbitrations",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1236), new DateTime(2024, 5, 29, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1243), new DateTime(2024, 5, 24, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1265), new DateTime(2024, 6, 3, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1268), new DateTime(2024, 5, 29, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1272), new DateTime(2024, 6, 8, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1278), new DateTime(2024, 6, 3, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1279) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1281), new DateTime(2024, 6, 13, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1284), new DateTime(2024, 6, 8, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1288), new DateTime(2024, 6, 18, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1290), new DateTime(2024, 6, 13, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4782));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4542));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(2185), new DateTime(2024, 5, 19, 17, 12, 58, 933, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(2308), new DateTime(2024, 5, 19, 17, 12, 58, 933, DateTimeKind.Local).AddTicks(2311) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(2326), new DateTime(2024, 5, 19, 17, 12, 58, 933, DateTimeKind.Local).AddTicks(2328) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(2334), new DateTime(2024, 5, 19, 17, 12, 58, 933, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(2335), new DateTime(2024, 5, 24, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(2340), new DateTime(2024, 5, 21, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(2355), new DateTime(2024, 5, 22, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(2360), new DateTime(2024, 5, 27, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(2363), new DateTime(2024, 5, 24, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(2365), new DateTime(2024, 5, 25, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3347), new DateTime(2024, 5, 29, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3618), new DateTime(2024, 6, 8, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4232));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3417));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3041));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 14, 12, 58, 933, DateTimeKind.Utc).AddTicks(1837));

            migrationBuilder.CreateIndex(
                name: "IX_FinalArbitrations_ParentId",
                table: "FinalArbitrations",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_FinalArbitrations_FinalArbitrations_ParentId",
                table: "FinalArbitrations",
                column: "ParentId",
                principalTable: "FinalArbitrations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FinalArbitrations_ProvidedForms_ProvidedFormId",
                table: "FinalArbitrations",
                column: "ProvidedFormId",
                principalTable: "ProvidedForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FinalArbitrations_FinalArbitrations_ParentId",
                table: "FinalArbitrations");

            migrationBuilder.DropForeignKey(
                name: "FK_FinalArbitrations_ProvidedForms_ProvidedFormId",
                table: "FinalArbitrations");

            migrationBuilder.DropIndex(
                name: "IX_FinalArbitrations_ParentId",
                table: "FinalArbitrations");

            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "FinalArbitrations");

            migrationBuilder.RenameColumn(
                name: "ProvidedFormId",
                table: "FinalArbitrations",
                newName: "ArbitrationId");

            migrationBuilder.RenameIndex(
                name: "IX_FinalArbitrations_ProvidedFormId",
                table: "FinalArbitrations",
                newName: "IX_FinalArbitrations_ArbitrationId");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAccepted",
                table: "ProvidedForms",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "isAcceptedFromChairman",
                table: "FinalArbitrations",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FinalScore",
                table: "FinalArbitrations",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9353), new DateTime(2024, 5, 29, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9363), new DateTime(2024, 5, 24, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9382), new DateTime(2024, 6, 3, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9385), new DateTime(2024, 5, 29, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9388), new DateTime(2024, 6, 8, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9391), new DateTime(2024, 6, 3, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9394), new DateTime(2024, 6, 13, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9396), new DateTime(2024, 6, 8, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9399), new DateTime(2024, 6, 18, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9402), new DateTime(2024, 6, 13, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4661));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4673));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4794));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3001));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3781));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4421));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4275));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(309), new DateTime(2024, 5, 19, 13, 50, 39, 353, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(419), new DateTime(2024, 5, 19, 13, 50, 39, 353, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(428), new DateTime(2024, 5, 19, 13, 50, 39, 353, DateTimeKind.Local).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(436), new DateTime(2024, 5, 19, 13, 50, 39, 353, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(5186), new DateTime(2024, 5, 24, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(5190), new DateTime(2024, 5, 21, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(5201), new DateTime(2024, 5, 22, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(5205), new DateTime(2024, 5, 27, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(5208), new DateTime(2024, 5, 24, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(5210), new DateTime(2024, 5, 25, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6055), new DateTime(2024, 5, 29, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6364), new DateTime(2024, 6, 8, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(6369) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 350, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.InsertData(
                table: "ProvidedForms",
                columns: new[] { "Id", "CategoryEducationalClassId", "CreatedAt", "CreatedBy", "CurrentStep", "CycleNumber", "CycleYear", "DeletedAt", "FinalScore", "IsAccepted", "LastModifiedAt", "LastModifiedBy", "PercentCompletion", "ReasonForRejection", "Status", "SubscriberType", "TotalStep", "Type", "categoryId", "isDeleted", "userId" },
                values: new object[] { 1, null, new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1837), null, 1, 1, "2023-2024", null, 0f, false, null, null, 1, null, 0, 0, 6, 0, 2, false, 1 });

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1189));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 353, DateTimeKind.Utc).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 19, 10, 50, 39, 352, DateTimeKind.Utc).AddTicks(9929));

            migrationBuilder.AddForeignKey(
                name: "FK_FinalArbitrations_Arbitrations_ArbitrationId",
                table: "FinalArbitrations",
                column: "ArbitrationId",
                principalTable: "Arbitrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
