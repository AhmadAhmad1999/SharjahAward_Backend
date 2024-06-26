using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable_ViewWhenRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ViewWhenRelations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DynamicAttributeId = table.Column<int>(type: "int", nullable: false),
                    DynamicAttributeListValueId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ViewWhenRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ViewWhenRelations_DynamicAttributeListValues_DynamicAttributeListValueId",
                        column: x => x.DynamicAttributeListValueId,
                        principalTable: "DynamicAttributeListValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ViewWhenRelations_DynamicAttributes_DynamicAttributeId",
                        column: x => x.DynamicAttributeId,
                        principalTable: "DynamicAttributes",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2022), new DateTime(2024, 7, 1, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2049), new DateTime(2024, 7, 5, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2047), new DateTime(2024, 6, 30, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2052), new DateTime(2024, 7, 7, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2061), new DateTime(2024, 7, 11, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2058), new DateTime(2024, 7, 6, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2059) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2063), new DateTime(2024, 7, 13, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2068), new DateTime(2024, 7, 17, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2065), new DateTime(2024, 7, 12, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2071), new DateTime(2024, 7, 19, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2077), new DateTime(2024, 7, 23, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2074), new DateTime(2024, 7, 18, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2079), new DateTime(2024, 7, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2085), new DateTime(2024, 7, 29, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2082), new DateTime(2024, 7, 24, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(961));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1105));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6879));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4258));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4271));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2773), new DateTime(2024, 6, 25, 16, 42, 49, 67, DateTimeKind.Local).AddTicks(2782) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2897), new DateTime(2024, 6, 25, 16, 42, 49, 67, DateTimeKind.Local).AddTicks(2900) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2917), new DateTime(2024, 6, 25, 16, 42, 49, 67, DateTimeKind.Local).AddTicks(2920) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2925), new DateTime(2024, 6, 25, 16, 42, 49, 67, DateTimeKind.Local).AddTicks(2927) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9053), new DateTime(2024, 6, 30, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9061), new DateTime(2024, 6, 27, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9112), new DateTime(2024, 6, 28, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9119), new DateTime(2024, 7, 3, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9123), new DateTime(2024, 6, 30, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9125), new DateTime(2024, 7, 1, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(9126) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(163), new DateTime(2024, 7, 5, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(169), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 25, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(436), new DateTime(2024, 7, 15, 13, 42, 49, 65, DateTimeKind.Utc).AddTicks(440), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4793));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4848));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4884));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4917));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4939));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4959));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4508));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4535));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(8403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 64, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 25, 13, 42, 49, 67, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.CreateIndex(
                name: "IX_ViewWhenRelations_DynamicAttributeId",
                table: "ViewWhenRelations",
                column: "DynamicAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ViewWhenRelations_DynamicAttributeListValueId",
                table: "ViewWhenRelations",
                column: "DynamicAttributeListValueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ViewWhenRelations");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6304), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 4, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6314), new DateTime(2024, 6, 29, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6328), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 9, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6330), new DateTime(2024, 7, 4, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6333), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 14, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6334), new DateTime(2024, 7, 9, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6337), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6339), new DateTime(2024, 7, 14, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6341), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6344), new DateTime(2024, 7, 19, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9861));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1248));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1318));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1326));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1329));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9466));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9469));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9700));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7947));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7955));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7003), new DateTime(2024, 6, 24, 17, 2, 51, 701, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7029), new DateTime(2024, 6, 24, 17, 2, 51, 701, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7033), new DateTime(2024, 6, 24, 17, 2, 51, 701, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7037), new DateTime(2024, 6, 24, 17, 2, 51, 701, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7639));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6865));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(69), new DateTime(2024, 6, 29, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(73), new DateTime(2024, 6, 26, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(80), new DateTime(2024, 6, 27, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(81) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(83), new DateTime(2024, 7, 2, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(86), new DateTime(2024, 6, 29, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(87), new DateTime(2024, 6, 30, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(88) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 702, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 702, DateTimeKind.Utc).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 702, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 702, DateTimeKind.Utc).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 702, DateTimeKind.Utc).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 702, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 702, DateTimeKind.Utc).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 702, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 702, DateTimeKind.Utc).AddTicks(53));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 702, DateTimeKind.Utc).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9591));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(823), new DateTime(2024, 7, 4, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(830), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1002), new DateTime(2024, 7, 14, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1005), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9355));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9359));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 699, DateTimeKind.Utc).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 699, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 699, DateTimeKind.Utc).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 699, DateTimeKind.Utc).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 699, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6601));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6800));
        }
    }
}
