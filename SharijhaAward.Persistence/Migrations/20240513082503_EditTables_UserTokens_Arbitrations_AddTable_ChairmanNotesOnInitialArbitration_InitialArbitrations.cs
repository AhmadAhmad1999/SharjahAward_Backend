using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTables_UserTokens_Arbitrations_AddTable_ChairmanNotesOnInitialArbitration_InitialArbitrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DeviceToken",
                table: "UserTokens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Arbitrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "InitialArbitrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CriterionId = table.Column<int>(type: "int", nullable: false),
                    ArbitrationId = table.Column<int>(type: "int", nullable: false),
                    StrengthPoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImprovementAreas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArbitrationScore = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InitialArbitrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InitialArbitrations_Arbitrations_ArbitrationId",
                        column: x => x.ArbitrationId,
                        principalTable: "Arbitrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InitialArbitrations_Criterions_CriterionId",
                        column: x => x.CriterionId,
                        principalTable: "Criterions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChairmanNotesOnInitialArbitrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChairmanId = table.Column<int>(type: "int", nullable: false),
                    InitialArbitrationId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChairmanNotesOnInitialArbitrations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChairmanNotesOnInitialArbitrations_Arbitrators_ChairmanId",
                        column: x => x.ChairmanId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChairmanNotesOnInitialArbitrations_InitialArbitrations_InitialArbitrationId",
                        column: x => x.InitialArbitrationId,
                        principalTable: "InitialArbitrations",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(663), new DateTime(2024, 5, 23, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(677), new DateTime(2024, 5, 18, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(701), new DateTime(2024, 5, 28, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(705), new DateTime(2024, 5, 23, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(713), new DateTime(2024, 6, 2, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(719), new DateTime(2024, 5, 28, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(722) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(726), new DateTime(2024, 6, 7, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(732), new DateTime(2024, 6, 2, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(736) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(740), new DateTime(2024, 6, 12, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(744), new DateTime(2024, 6, 7, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3693));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4988));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5918));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5930));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2170), new DateTime(2024, 5, 13, 11, 24, 56, 267, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2316), new DateTime(2024, 5, 13, 11, 24, 56, 267, DateTimeKind.Local).AddTicks(2320) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2331), new DateTime(2024, 5, 13, 11, 24, 56, 267, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2362), new DateTime(2024, 5, 13, 11, 24, 56, 267, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4381), new DateTime(2024, 5, 18, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4390), new DateTime(2024, 5, 15, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4410), new DateTime(2024, 5, 16, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4419), new DateTime(2024, 5, 21, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4424), new DateTime(2024, 5, 18, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4428), new DateTime(2024, 5, 19, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4431) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5296));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(6980));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(7165));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(5929), new DateTime(2024, 5, 23, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(5940), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(6423), new DateTime(2024, 6, 2, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(6430), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5416));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5484));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5491));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5603));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 264, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 268, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 13, 8, 24, 56, 267, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.CreateIndex(
                name: "IX_ChairmanNotesOnInitialArbitrations_ChairmanId",
                table: "ChairmanNotesOnInitialArbitrations",
                column: "ChairmanId");

            migrationBuilder.CreateIndex(
                name: "IX_ChairmanNotesOnInitialArbitrations_InitialArbitrationId",
                table: "ChairmanNotesOnInitialArbitrations",
                column: "InitialArbitrationId");

            migrationBuilder.CreateIndex(
                name: "IX_InitialArbitrations_ArbitrationId",
                table: "InitialArbitrations",
                column: "ArbitrationId");

            migrationBuilder.CreateIndex(
                name: "IX_InitialArbitrations_CriterionId",
                table: "InitialArbitrations",
                column: "CriterionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChairmanNotesOnInitialArbitrations");

            migrationBuilder.DropTable(
                name: "InitialArbitrations");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Arbitrations");

            migrationBuilder.AlterColumn<string>(
                name: "DeviceToken",
                table: "UserTokens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3303), new DateTime(2024, 5, 22, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3311), new DateTime(2024, 5, 17, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3330), new DateTime(2024, 5, 27, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3333), new DateTime(2024, 5, 22, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3358), new DateTime(2024, 6, 1, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3361), new DateTime(2024, 5, 27, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3365), new DateTime(2024, 6, 6, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3367), new DateTime(2024, 6, 1, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3371), new DateTime(2024, 6, 11, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3373), new DateTime(2024, 6, 6, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5916));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(6056));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(6064));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(6069));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5802));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7032));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7444));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4091), new DateTime(2024, 5, 12, 19, 8, 9, 860, DateTimeKind.Local).AddTicks(4099) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4207), new DateTime(2024, 5, 12, 19, 8, 9, 860, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4215), new DateTime(2024, 5, 12, 19, 8, 9, 860, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4233), new DateTime(2024, 5, 12, 19, 8, 9, 860, DateTimeKind.Local).AddTicks(4235) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4994));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3887));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(4051), new DateTime(2024, 5, 17, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(4056), new DateTime(2024, 5, 14, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(4072), new DateTime(2024, 5, 15, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(4079), new DateTime(2024, 5, 20, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(4082), new DateTime(2024, 5, 17, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(4084), new DateTime(2024, 5, 18, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5107), new DateTime(2024, 5, 22, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5113), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5413), new DateTime(2024, 6, 1, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(5417), "Saturday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5834));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5891));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5950));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6833));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(3882));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 858, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 12, 16, 8, 9, 860, DateTimeKind.Utc).AddTicks(3787));
        }
    }
}
