using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddTables_ArbitratorForms_CoordinatorForms_EditTables_ProvidedForms_DynamicAttributeValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReasonForRejection",
                table: "ProvidedForms",
                newName: "ReasonOfRejection");

            migrationBuilder.AlterColumn<bool>(
                name: "isAccepted",
                table: "DynamicAttributeValues",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<string>(
                name: "ReasonForRejecting",
                table: "DynamicAttributeValues",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ArbitratorForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    ArbitratorId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArbitratorForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArbitratorForms_Arbitrators_ArbitratorId",
                        column: x => x.ArbitratorId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArbitratorForms_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CoordinatorForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvidedFormId = table.Column<int>(type: "int", nullable: false),
                    CoordinatorId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoordinatorForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CoordinatorForms_Coordinators_CoordinatorId",
                        column: x => x.CoordinatorId,
                        principalTable: "Coordinators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoordinatorForms_ProvidedForms_ProvidedFormId",
                        column: x => x.ProvidedFormId,
                        principalTable: "ProvidedForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3200), new DateTime(2024, 5, 30, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3212), new DateTime(2024, 5, 25, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3229), new DateTime(2024, 6, 4, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3234), new DateTime(2024, 5, 30, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3237), new DateTime(2024, 6, 9, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3239), new DateTime(2024, 6, 4, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3244), new DateTime(2024, 6, 14, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3246), new DateTime(2024, 6, 9, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3251), new DateTime(2024, 6, 19, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3253), new DateTime(2024, 6, 14, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3642));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3672));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3591));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7992));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7998));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8002));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5733));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4995));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5098));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3943), new DateTime(2024, 5, 20, 10, 48, 6, 603, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4060), new DateTime(2024, 5, 20, 10, 48, 6, 603, DateTimeKind.Local).AddTicks(4062) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4082), new DateTime(2024, 5, 20, 10, 48, 6, 603, DateTimeKind.Local).AddTicks(4085) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4089), new DateTime(2024, 5, 20, 10, 48, 6, 603, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2045), new DateTime(2024, 5, 25, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2050), new DateTime(2024, 5, 22, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2062), new DateTime(2024, 5, 23, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2067), new DateTime(2024, 5, 28, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2069), new DateTime(2024, 5, 25, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2071), new DateTime(2024, 5, 26, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3086), new DateTime(2024, 5, 30, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3091), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3318), new DateTime(2024, 6, 9, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(3321), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5371));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5414));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5438));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5478));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5495));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 601, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 20, 7, 48, 6, 603, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorForms_ArbitratorId",
                table: "ArbitratorForms",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorForms_ProvidedFormId",
                table: "ArbitratorForms",
                column: "ProvidedFormId");

            migrationBuilder.CreateIndex(
                name: "IX_CoordinatorForms_CoordinatorId",
                table: "CoordinatorForms",
                column: "CoordinatorId");

            migrationBuilder.CreateIndex(
                name: "IX_CoordinatorForms_ProvidedFormId",
                table: "CoordinatorForms",
                column: "ProvidedFormId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArbitratorForms");

            migrationBuilder.DropTable(
                name: "CoordinatorForms");

            migrationBuilder.DropColumn(
                name: "ReasonForRejecting",
                table: "DynamicAttributeValues");

            migrationBuilder.RenameColumn(
                name: "ReasonOfRejection",
                table: "ProvidedForms",
                newName: "ReasonForRejection");

            migrationBuilder.AlterColumn<bool>(
                name: "isAccepted",
                table: "DynamicAttributeValues",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

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
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3347), new DateTime(2024, 5, 29, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3353), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 19, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3618), new DateTime(2024, 6, 8, 14, 12, 58, 931, DateTimeKind.Utc).AddTicks(3622), "Saturday" });

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
        }
    }
}
