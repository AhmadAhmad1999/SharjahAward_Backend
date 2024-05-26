using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddTables_AdvancedFormBuilderTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilderPatterns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicPlaceHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishPlaceHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsUnique = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilderPatterns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VirtualTableForSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VirtualTableForSections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VirtualTables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VirtualTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilderPatternValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvancedFormBuilderPatternId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilderPatternValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderPatternValues_AdvancedFormBuilderPatterns_AdvancedFormBuilderPatternId",
                        column: x => x.AdvancedFormBuilderPatternId,
                        principalTable: "AdvancedFormBuilderPatterns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilderSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ArabicName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TableTypeSection = table.Column<bool>(type: "bit", nullable: false),
                    VirtualTableForSectioniD = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilderSections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderSections_VirtualTableForSections_VirtualTableForSectioniD",
                        column: x => x.VirtualTableForSectioniD,
                        principalTable: "VirtualTableForSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishLabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicPlaceHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishPlaceHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    IsUnique = table.Column<bool>(type: "bit", nullable: false),
                    LinkedToAnotherAttribute = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    MaxSizeInKB = table.Column<int>(type: "int", nullable: true),
                    AttributeDataTypeId = table.Column<int>(type: "int", nullable: false),
                    AdvancedFormBuilderSectionId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilders_AdvancedFormBuilderSections_AdvancedFormBuilderSectionId",
                        column: x => x.AdvancedFormBuilderSectionId,
                        principalTable: "AdvancedFormBuilderSections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilders_AttributeDataTypes_AttributeDataTypeId",
                        column: x => x.AttributeDataTypeId,
                        principalTable: "AttributeDataTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilderListValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvancedFormBuilderId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilderListValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderListValues_AdvancedFormBuilders_AdvancedFormBuilderId",
                        column: x => x.AdvancedFormBuilderId,
                        principalTable: "AdvancedFormBuilders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilderTableValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false),
                    RecordId = table.Column<int>(type: "int", nullable: false),
                    AdvancedFormBuilderId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilderTableValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderTableValues_AdvancedFormBuilders_AdvancedFormBuilderId",
                        column: x => x.AdvancedFormBuilderId,
                        principalTable: "AdvancedFormBuilders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderTableValues_VirtualTables_RecordId",
                        column: x => x.RecordId,
                        principalTable: "VirtualTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvancedFormBuilderValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordId = table.Column<int>(type: "int", nullable: false),
                    AdvancedFormBuilderId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvancedFormBuilderValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderValues_AdvancedFormBuilders_AdvancedFormBuilderId",
                        column: x => x.AdvancedFormBuilderId,
                        principalTable: "AdvancedFormBuilders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvancedFormBuilderValues_VirtualTables_RecordId",
                        column: x => x.RecordId,
                        principalTable: "VirtualTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1330), new DateTime(2024, 6, 5, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1341), new DateTime(2024, 5, 31, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1354) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1357), new DateTime(2024, 6, 10, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1360), new DateTime(2024, 6, 5, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1364), new DateTime(2024, 6, 15, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1366), new DateTime(2024, 6, 10, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1368) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1370), new DateTime(2024, 6, 20, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1372), new DateTime(2024, 6, 15, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1375), new DateTime(2024, 6, 25, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1379), new DateTime(2024, 6, 20, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5227));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6416));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3923));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3657));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2169), new DateTime(2024, 5, 26, 14, 0, 12, 677, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2302), new DateTime(2024, 5, 26, 14, 0, 12, 677, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2322), new DateTime(2024, 5, 26, 14, 0, 12, 677, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2330), new DateTime(2024, 5, 26, 14, 0, 12, 677, DateTimeKind.Local).AddTicks(2332) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(325), new DateTime(2024, 5, 31, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(332), new DateTime(2024, 5, 28, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(349), new DateTime(2024, 5, 29, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(354), new DateTime(2024, 6, 3, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(357), new DateTime(2024, 5, 31, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(359), new DateTime(2024, 6, 1, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1313), new DateTime(2024, 6, 5, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1318) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1569), new DateTime(2024, 6, 15, 11, 0, 12, 675, DateTimeKind.Utc).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4772));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4775));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4780));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4784));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4786));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4790));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4796));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4805));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4808));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4870));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5815));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4120), "AboutAward" });

            migrationBuilder.InsertData(
                table: "PermissionHeaders",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "isDeleted" },
                values: new object[,]
                {
                    { 2, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4123), null, null, null, null, "Album", false },
                    { 3, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4126), null, null, null, null, "AppVersion", false },
                    { 4, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4129), null, null, null, null, "AwardPublication", false },
                    { 5, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4132), null, null, null, null, "AwardSponsor", false },
                    { 6, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4136), null, null, null, null, "Circular", false },
                    { 7, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4139), null, null, null, null, "Class", false },
                    { 8, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4144), null, null, null, null, "ClassArbitrator", false },
                    { 9, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4146), null, null, null, null, "Cycle", false },
                    { 10, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4150), null, null, null, null, "Agenda", false },
                    { 11, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4152), null, null, null, null, "Category", false },
                    { 12, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4155), null, null, null, null, "GeneralCondition", false },
                    { 13, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4158), null, null, null, null, "EducationalEntity", false },
                    { 14, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4161), null, null, null, null, "SystemFiles", false },
                    { 15, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4164), null, null, null, null, "GeneralWorkshop", false },
                    { 16, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4167), null, null, null, null, "Instruction", false },
                    { 17, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4170), null, null, null, null, "Meeting", false },
                    { 18, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4172), null, null, null, null, "News", false },
                    { 19, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4176), null, null, null, null, "Notification", false },
                    { 20, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4180), null, null, null, null, "NotificationTemplate", false },
                    { 21, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4200), null, null, null, null, "Role", false },
                    { 22, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4204), null, null, null, null, "User", false },
                    { 23, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4207), null, null, null, null, "Coordinator", false },
                    { 24, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4210), null, null, null, null, "Arbitrator", false },
                    { 25, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4213), null, null, null, null, "Committee", false },
                    { 26, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4216), null, null, null, null, "SubscriberAccount", false },
                    { 27, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4219), null, null, null, null, "SubscriberProfile", false },
                    { 28, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4222), null, null, null, null, "SubscriberForm", false },
                    { 29, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4227), null, null, null, null, "Event", false },
                    { 30, new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(4230), null, null, null, null, "ContactUs", false }
                });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 674, DateTimeKind.Utc).AddTicks(9882), 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 674, DateTimeKind.Utc).AddTicks(9891), 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 674, DateTimeKind.Utc).AddTicks(9894), 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 674, DateTimeKind.Utc).AddTicks(9897), 9 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 5, 26, 11, 0, 12, 674, DateTimeKind.Utc).AddTicks(9901), 9 });

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6854));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 11, 0, 12, 677, DateTimeKind.Utc).AddTicks(1840));

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderListValues_AdvancedFormBuilderId",
                table: "AdvancedFormBuilderListValues",
                column: "AdvancedFormBuilderId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderPatternValues_AdvancedFormBuilderPatternId",
                table: "AdvancedFormBuilderPatternValues",
                column: "AdvancedFormBuilderPatternId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilders_AdvancedFormBuilderSectionId",
                table: "AdvancedFormBuilders",
                column: "AdvancedFormBuilderSectionId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilders_AttributeDataTypeId",
                table: "AdvancedFormBuilders",
                column: "AttributeDataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderSections_VirtualTableForSectioniD",
                table: "AdvancedFormBuilderSections",
                column: "VirtualTableForSectioniD");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderTableValues_AdvancedFormBuilderId",
                table: "AdvancedFormBuilderTableValues",
                column: "AdvancedFormBuilderId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderTableValues_RecordId",
                table: "AdvancedFormBuilderTableValues",
                column: "RecordId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderValues_AdvancedFormBuilderId",
                table: "AdvancedFormBuilderValues",
                column: "AdvancedFormBuilderId");

            migrationBuilder.CreateIndex(
                name: "IX_AdvancedFormBuilderValues_RecordId",
                table: "AdvancedFormBuilderValues",
                column: "RecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvancedFormBuilderListValues");

            migrationBuilder.DropTable(
                name: "AdvancedFormBuilderPatternValues");

            migrationBuilder.DropTable(
                name: "AdvancedFormBuilderTableValues");

            migrationBuilder.DropTable(
                name: "AdvancedFormBuilderValues");

            migrationBuilder.DropTable(
                name: "AdvancedFormBuilderPatterns");

            migrationBuilder.DropTable(
                name: "AdvancedFormBuilders");

            migrationBuilder.DropTable(
                name: "VirtualTables");

            migrationBuilder.DropTable(
                name: "AdvancedFormBuilderSections");

            migrationBuilder.DropTable(
                name: "VirtualTableForSections");

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8667), new DateTime(2024, 6, 5, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8682), new DateTime(2024, 5, 31, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8698) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8701), new DateTime(2024, 6, 10, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8704), new DateTime(2024, 6, 5, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8708), new DateTime(2024, 6, 15, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8712), new DateTime(2024, 6, 10, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8713) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8715), new DateTime(2024, 6, 20, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8717), new DateTime(2024, 6, 15, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8721), new DateTime(2024, 6, 25, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8724), new DateTime(2024, 6, 20, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3775));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3779));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 404, DateTimeKind.Utc).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3964));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2501));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3298));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9633), new DateTime(2024, 5, 26, 11, 15, 35, 405, DateTimeKind.Local).AddTicks(9643) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9750), new DateTime(2024, 5, 26, 11, 15, 35, 405, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(48), new DateTime(2024, 5, 26, 11, 15, 35, 406, DateTimeKind.Local).AddTicks(49) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(55), new DateTime(2024, 5, 26, 11, 15, 35, 406, DateTimeKind.Local).AddTicks(58) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8146), new DateTime(2024, 5, 31, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8151), new DateTime(2024, 5, 28, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8172), new DateTime(2024, 5, 29, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8177), new DateTime(2024, 6, 3, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8180), new DateTime(2024, 5, 31, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8182), new DateTime(2024, 6, 1, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8183) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2998));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9585));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9128), new DateTime(2024, 6, 5, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9495), new DateTime(2024, 6, 15, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(9499) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(144));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1416));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1435));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1438));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1443));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1503));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(7613), "إدارة الدورات" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8043), 1 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8047), 1 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8050), 1 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8053), 1 });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PermissionHeaderId" },
                values: new object[] { new DateTime(2024, 5, 26, 8, 15, 35, 403, DateTimeKind.Utc).AddTicks(8057), 1 });

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(4066));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(3207));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 406, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9312));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9317));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 26, 8, 15, 35, 405, DateTimeKind.Utc).AddTicks(9326));
        }
    }
}
