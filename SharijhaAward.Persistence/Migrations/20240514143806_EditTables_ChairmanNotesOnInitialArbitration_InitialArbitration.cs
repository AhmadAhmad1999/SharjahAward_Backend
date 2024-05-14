using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTables_ChairmanNotesOnInitialArbitration_InitialArbitration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InitialArbitrations_Criterions_CriterionId",
                table: "InitialArbitrations");

            migrationBuilder.AlterColumn<int>(
                name: "CriterionId",
                table: "InitialArbitrations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CriterionItemId",
                table: "InitialArbitrations",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3234), new DateTime(2024, 5, 24, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3245), new DateTime(2024, 5, 19, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3262), new DateTime(2024, 5, 29, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3267), new DateTime(2024, 5, 24, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3274), new DateTime(2024, 6, 3, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3278), new DateTime(2024, 5, 29, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3286), new DateTime(2024, 6, 8, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3290), new DateTime(2024, 6, 3, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3296), new DateTime(2024, 6, 13, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3300), new DateTime(2024, 6, 8, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4389), new DateTime(2024, 5, 14, 17, 38, 0, 526, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4528), new DateTime(2024, 5, 14, 17, 38, 0, 526, DateTimeKind.Local).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4544), new DateTime(2024, 5, 14, 17, 38, 0, 526, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4557), new DateTime(2024, 5, 14, 17, 38, 0, 526, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5485), new DateTime(2024, 5, 19, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5493), new DateTime(2024, 5, 16, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5508), new DateTime(2024, 5, 17, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5516), new DateTime(2024, 5, 22, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5522), new DateTime(2024, 5, 19, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5525), new DateTime(2024, 5, 20, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(6842), new DateTime(2024, 5, 24, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(6851) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7196), new DateTime(2024, 6, 3, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.CreateIndex(
                name: "IX_InitialArbitrations_CriterionItemId",
                table: "InitialArbitrations",
                column: "CriterionItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_InitialArbitrations_CriterionItems_CriterionItemId",
                table: "InitialArbitrations",
                column: "CriterionItemId",
                principalTable: "CriterionItems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_InitialArbitrations_Criterions_CriterionId",
                table: "InitialArbitrations",
                column: "CriterionId",
                principalTable: "Criterions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InitialArbitrations_CriterionItems_CriterionItemId",
                table: "InitialArbitrations");

            migrationBuilder.DropForeignKey(
                name: "FK_InitialArbitrations_Criterions_CriterionId",
                table: "InitialArbitrations");

            migrationBuilder.DropIndex(
                name: "IX_InitialArbitrations_CriterionItemId",
                table: "InitialArbitrations");

            migrationBuilder.DropColumn(
                name: "CriterionItemId",
                table: "InitialArbitrations");

            migrationBuilder.AlterColumn<int>(
                name: "CriterionId",
                table: "InitialArbitrations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8115), new DateTime(2024, 5, 24, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 14, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8502), new DateTime(2024, 6, 3, 7, 56, 48, 918, DateTimeKind.Utc).AddTicks(8512) });

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
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 7, 56, 48, 922, DateTimeKind.Utc).AddTicks(6054));

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

            migrationBuilder.AddForeignKey(
                name: "FK_InitialArbitrations_Criterions_CriterionId",
                table: "InitialArbitrations",
                column: "CriterionId",
                principalTable: "Criterions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
