using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewComponentInPageStruct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImageCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageCards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TextCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageStructureId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TextCards_PageStructures_PageStructureId",
                        column: x => x.PageStructureId,
                        principalTable: "PageStructures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PageStructureImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageStructureImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PageStructureImages_ImageCards_ImageId",
                        column: x => x.ImageId,
                        principalTable: "ImageCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4793), new DateTime(2024, 7, 8, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4803), new DateTime(2024, 7, 12, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4802), new DateTime(2024, 7, 7, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4804), new DateTime(2024, 7, 14, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4807), new DateTime(2024, 7, 18, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4806), new DateTime(2024, 7, 13, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4808), new DateTime(2024, 7, 20, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4811), new DateTime(2024, 7, 24, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4810), new DateTime(2024, 7, 19, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4812), new DateTime(2024, 7, 26, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4815), new DateTime(2024, 7, 30, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4813), new DateTime(2024, 7, 25, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4816), new DateTime(2024, 8, 1, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4819), new DateTime(2024, 8, 5, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4817), new DateTime(2024, 7, 31, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6661));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6845));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6170));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5623));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5077), new DateTime(2024, 7, 2, 11, 19, 43, 295, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5096), new DateTime(2024, 7, 2, 11, 19, 43, 295, DateTimeKind.Local).AddTicks(5097) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5098), new DateTime(2024, 7, 2, 11, 19, 43, 295, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5100), new DateTime(2024, 7, 2, 11, 19, 43, 295, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5450));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5457));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5461));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5860), new DateTime(2024, 7, 7, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5863), new DateTime(2024, 7, 4, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5869), new DateTime(2024, 7, 5, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5872), new DateTime(2024, 7, 10, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5874), new DateTime(2024, 7, 7, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5875), new DateTime(2024, 7, 8, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6326), new DateTime(2024, 7, 12, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6329), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6453), new DateTime(2024, 7, 22, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(6455), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5897));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5956));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5963));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5965));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5561));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 294, DateTimeKind.Utc).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4890));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4894));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 7, 2, 8, 19, 43, 295, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.CreateIndex(
                name: "IX_PageStructureImages_ImageId",
                table: "PageStructureImages",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_TextCards_PageStructureId",
                table: "TextCards",
                column: "PageStructureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PageStructureImages");

            migrationBuilder.DropTable(
                name: "TextCards");

            migrationBuilder.DropTable(
                name: "ImageCards");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6041), new DateTime(2024, 7, 3, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6049), new DateTime(2024, 7, 7, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6048), new DateTime(2024, 7, 2, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6050), new DateTime(2024, 7, 9, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6053), new DateTime(2024, 7, 13, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6051), new DateTime(2024, 7, 8, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6054), new DateTime(2024, 7, 15, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6057), new DateTime(2024, 7, 19, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6055), new DateTime(2024, 7, 14, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6058), new DateTime(2024, 7, 21, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6062), new DateTime(2024, 7, 25, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6060), new DateTime(2024, 7, 20, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6063), new DateTime(2024, 7, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6066), new DateTime(2024, 7, 31, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6064), new DateTime(2024, 7, 26, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7885));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6447), new DateTime(2024, 6, 27, 10, 36, 56, 930, DateTimeKind.Local).AddTicks(6456) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6474), new DateTime(2024, 6, 27, 10, 36, 56, 930, DateTimeKind.Local).AddTicks(6475) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6476), new DateTime(2024, 6, 27, 10, 36, 56, 930, DateTimeKind.Local).AddTicks(6477) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6478), new DateTime(2024, 6, 27, 10, 36, 56, 930, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6924));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7280), new DateTime(2024, 7, 2, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7283), new DateTime(2024, 6, 29, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7290), new DateTime(2024, 6, 30, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7292), new DateTime(2024, 7, 5, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7294), new DateTime(2024, 7, 2, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7295), new DateTime(2024, 7, 3, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8788));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7813), new DateTime(2024, 7, 7, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7817), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7951), new DateTime(2024, 7, 17, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(7953), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7470));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7485));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7509));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7511));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7522));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7531));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8091));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7287));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7308));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7319));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7322));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7323));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6689));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6751));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6755));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6765));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 929, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8734));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 27, 7, 36, 56, 930, DateTimeKind.Utc).AddTicks(6311));
        }
    }
}
