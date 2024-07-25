using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addIndexTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Index",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Index", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6413), new DateTime(2024, 7, 31, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6422), new DateTime(2024, 8, 4, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6421), new DateTime(2024, 7, 30, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6417) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6423), new DateTime(2024, 8, 6, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6427), new DateTime(2024, 8, 10, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6425), new DateTime(2024, 8, 5, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6426) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6428), new DateTime(2024, 8, 12, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6431), new DateTime(2024, 8, 16, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6429), new DateTime(2024, 8, 11, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6430) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6432), new DateTime(2024, 8, 18, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6435), new DateTime(2024, 8, 22, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6434), new DateTime(2024, 8, 17, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6435) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6436), new DateTime(2024, 8, 24, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6439), new DateTime(2024, 8, 28, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6438), new DateTime(2024, 8, 23, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8398));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8401));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8460));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8249));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7248));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7912), new DateTime(2024, 7, 30, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7915), new DateTime(2024, 7, 27, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7923), new DateTime(2024, 7, 28, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7925), new DateTime(2024, 8, 2, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7927), new DateTime(2024, 7, 30, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7928), new DateTime(2024, 7, 31, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7929) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8099));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8544));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8556));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8469), new DateTime(2024, 8, 4, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8473), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8641), new DateTime(2024, 8, 14, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(8643), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7527));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7532));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7353));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7361));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7365));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7369));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7397));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7409));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7451));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7455));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7482));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 795, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 25, 10, 15, 41, 796, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.CreateIndex(
                name: "IX_Index_ArabicName",
                table: "Index",
                column: "ArabicName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Index_EnglishName",
                table: "Index",
                column: "EnglishName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Index_Slug",
                table: "Index",
                column: "Slug",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Index");

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
    }
}
