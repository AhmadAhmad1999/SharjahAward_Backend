using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_DynamicAttributeSection_AddTable_DynamicAttributeTableValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TableTypeSection",
                table: "DynamicAttributeSections",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "DynamicAttributeTableValue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false),
                    RecordId = table.Column<int>(type: "int", nullable: false),
                    isAccepted = table.Column<bool>(type: "bit", nullable: true),
                    ReasonForRejecting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DynamicAttributeId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicAttributeTableValue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DynamicAttributeTableValue_DynamicAttributes_DynamicAttributeId",
                        column: x => x.DynamicAttributeId,
                        principalTable: "DynamicAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7840), new DateTime(2024, 6, 2, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7856), new DateTime(2024, 5, 28, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7879), new DateTime(2024, 6, 7, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7884), new DateTime(2024, 6, 2, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7889), new DateTime(2024, 6, 12, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7892), new DateTime(2024, 6, 7, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7894) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7897), new DateTime(2024, 6, 17, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7900), new DateTime(2024, 6, 12, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7905), new DateTime(2024, 6, 22, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7908), new DateTime(2024, 6, 17, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4655));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4787));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4807));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "TableTypeSection" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1159), false });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9070), new DateTime(2024, 5, 23, 9, 53, 44, 679, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9210), new DateTime(2024, 5, 23, 9, 53, 44, 679, DateTimeKind.Local).AddTicks(9213) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9239), new DateTime(2024, 5, 23, 9, 53, 44, 679, DateTimeKind.Local).AddTicks(9246) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9266), new DateTime(2024, 5, 23, 9, 53, 44, 679, DateTimeKind.Local).AddTicks(9270) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(728));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8900));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(7979), new DateTime(2024, 5, 28, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(7985), new DateTime(2024, 5, 25, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(8004), new DateTime(2024, 5, 26, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(8011), new DateTime(2024, 5, 31, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(8016), new DateTime(2024, 5, 28, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(8019), new DateTime(2024, 5, 29, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(9859), new DateTime(2024, 6, 2, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(9865), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 23, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(172), new DateTime(2024, 6, 12, 6, 53, 44, 677, DateTimeKind.Utc).AddTicks(175), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9510));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3456));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(7852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 676, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(5179));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 680, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 23, 6, 53, 44, 679, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributeTableValue_DynamicAttributeId",
                table: "DynamicAttributeTableValue",
                column: "DynamicAttributeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DynamicAttributeTableValue");

            migrationBuilder.DropColumn(
                name: "TableTypeSection",
                table: "DynamicAttributeSections");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(1787), new DateTime(2024, 5, 31, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(1797), new DateTime(2024, 5, 26, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(1812) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(1814), new DateTime(2024, 6, 5, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(1816), new DateTime(2024, 5, 31, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(1820), new DateTime(2024, 6, 10, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(1823), new DateTime(2024, 6, 5, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(1827), new DateTime(2024, 6, 15, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(1829), new DateTime(2024, 6, 10, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(1832), new DateTime(2024, 6, 20, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(1834), new DateTime(2024, 6, 15, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6785));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6795));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6810));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7387));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7391));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7394));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5427));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5164));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4468));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(3078), new DateTime(2024, 5, 21, 18, 20, 55, 743, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(3212), new DateTime(2024, 5, 21, 18, 20, 55, 743, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(3229), new DateTime(2024, 5, 21, 18, 20, 55, 743, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(3235), new DateTime(2024, 5, 21, 18, 20, 55, 743, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(5563), new DateTime(2024, 5, 26, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(5569), new DateTime(2024, 5, 23, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(5583), new DateTime(2024, 5, 24, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(5585) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(5588), new DateTime(2024, 5, 29, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(5591), new DateTime(2024, 5, 26, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(5593), new DateTime(2024, 5, 27, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(5594) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(6940));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(6392), new DateTime(2024, 5, 31, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(6401), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(6733), new DateTime(2024, 6, 10, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(6737), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4759));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4779));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4788));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 741, DateTimeKind.Utc).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6997));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4200));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 21, 15, 20, 55, 743, DateTimeKind.Utc).AddTicks(2663));
        }
    }
}
