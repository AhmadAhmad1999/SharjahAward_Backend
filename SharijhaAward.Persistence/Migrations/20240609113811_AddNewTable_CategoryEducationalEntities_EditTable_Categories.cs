using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable_CategoryEducationalEntities_EditTable_Categories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "RelatedToEducationalEntities",
                table: "Categories",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CategoryEducationalEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationalEntityId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryEducationalEntities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryEducationalEntities_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryEducationalEntities_EducationalEntities_EducationalEntityId",
                        column: x => x.EducationalEntityId,
                        principalTable: "EducationalEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "CreatedAt", "RelatedToEducationalEntities" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6693), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedToEducationalEntities" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6708), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedToEducationalEntities" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6720), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedToEducationalEntities" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6745), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "RelatedToEducationalEntities" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6756), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "RelatedToEducationalEntities" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6765), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "RelatedToEducationalEntities" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6773), null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "RelatedToEducationalEntities" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 38, 6, 422, DateTimeKind.Utc).AddTicks(6781), null });

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

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEducationalEntities_CategoryId",
                table: "CategoryEducationalEntities",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEducationalEntities_EducationalEntityId",
                table: "CategoryEducationalEntities",
                column: "EducationalEntityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryEducationalEntities");

            migrationBuilder.DropColumn(
                name: "RelatedToEducationalEntities",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7299), new DateTime(2024, 6, 19, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7305), new DateTime(2024, 6, 14, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7316), new DateTime(2024, 6, 24, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7318), new DateTime(2024, 6, 19, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7321), new DateTime(2024, 6, 29, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7322), new DateTime(2024, 6, 24, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7325), new DateTime(2024, 7, 4, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7326), new DateTime(2024, 6, 29, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7327) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7329), new DateTime(2024, 7, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7330), new DateTime(2024, 7, 4, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7331) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7489));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(40));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(46));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7724), new DateTime(2024, 6, 9, 14, 24, 27, 490, DateTimeKind.Local).AddTicks(7733) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7752), new DateTime(2024, 6, 9, 14, 24, 27, 490, DateTimeKind.Local).AddTicks(7754) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7755), new DateTime(2024, 6, 9, 14, 24, 27, 490, DateTimeKind.Local).AddTicks(7756) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7758), new DateTime(2024, 6, 9, 14, 24, 27, 490, DateTimeKind.Local).AddTicks(7759) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7627));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(3634), new DateTime(2024, 6, 14, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(3637), new DateTime(2024, 6, 11, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(3647), new DateTime(2024, 6, 12, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(3650), new DateTime(2024, 6, 17, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(3653), new DateTime(2024, 6, 14, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(3655), new DateTime(2024, 6, 15, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4200), new DateTime(2024, 6, 19, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4424), new DateTime(2024, 6, 29, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8999));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9049));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9051));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9117));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9123));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(3137));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 489, DateTimeKind.Utc).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 491, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 11, 24, 27, 490, DateTimeKind.Utc).AddTicks(7589));
        }
    }
}
