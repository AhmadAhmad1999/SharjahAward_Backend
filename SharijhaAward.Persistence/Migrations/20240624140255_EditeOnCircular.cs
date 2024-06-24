using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditeOnCircular : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArabicFileUrl",
                table: "Circulars");

            migrationBuilder.DropColumn(
                name: "EnglishFileUrl",
                table: "Circulars");

            migrationBuilder.RenameColumn(
                name: "EnglishTitle",
                table: "Circulars",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "ArabicTitle",
                table: "Circulars",
                newName: "CircularText");

            migrationBuilder.CreateTable(
                name: "CircularArbitrators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CircularId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_CircularArbitrators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CircularArbitrators_Arbitrators_ArbitratorId",
                        column: x => x.ArbitratorId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CircularArbitrators_Circulars_CircularId",
                        column: x => x.CircularId,
                        principalTable: "Circulars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CircularAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachementPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CircularId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CircularAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CircularAttachments_Circulars_CircularId",
                        column: x => x.CircularId,
                        principalTable: "Circulars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CircularChairmans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CircularId = table.Column<int>(type: "int", nullable: false),
                    ChairmanId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CircularChairmans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CircularChairmans_Arbitrators_ChairmanId",
                        column: x => x.ChairmanId,
                        principalTable: "Arbitrators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CircularChairmans_Circulars_CircularId",
                        column: x => x.CircularId,
                        principalTable: "Circulars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CircularCoordinators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CircularId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_CircularCoordinators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CircularCoordinators_Circulars_CircularId",
                        column: x => x.CircularId,
                        principalTable: "Circulars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CircularCoordinators_Coordinators_CoordinatorId",
                        column: x => x.CoordinatorId,
                        principalTable: "Coordinators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6304), new DateTime(2024, 7, 4, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6314), new DateTime(2024, 6, 29, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6325) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6328), new DateTime(2024, 7, 9, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6330), new DateTime(2024, 7, 4, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6333), new DateTime(2024, 7, 14, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6334), new DateTime(2024, 7, 9, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6337), new DateTime(2024, 7, 19, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6339), new DateTime(2024, 7, 14, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6341), new DateTime(2024, 7, 24, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6344), new DateTime(2024, 7, 19, 14, 2, 51, 701, DateTimeKind.Utc).AddTicks(6345) });

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
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(823), new DateTime(2024, 7, 4, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 24, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1002), new DateTime(2024, 7, 14, 14, 2, 51, 700, DateTimeKind.Utc).AddTicks(1005) });

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

            migrationBuilder.CreateIndex(
                name: "IX_CircularArbitrators_ArbitratorId",
                table: "CircularArbitrators",
                column: "ArbitratorId");

            migrationBuilder.CreateIndex(
                name: "IX_CircularArbitrators_CircularId",
                table: "CircularArbitrators",
                column: "CircularId");

            migrationBuilder.CreateIndex(
                name: "IX_CircularAttachments_CircularId",
                table: "CircularAttachments",
                column: "CircularId");

            migrationBuilder.CreateIndex(
                name: "IX_CircularChairmans_ChairmanId",
                table: "CircularChairmans",
                column: "ChairmanId");

            migrationBuilder.CreateIndex(
                name: "IX_CircularChairmans_CircularId",
                table: "CircularChairmans",
                column: "CircularId");

            migrationBuilder.CreateIndex(
                name: "IX_CircularCoordinators_CircularId",
                table: "CircularCoordinators",
                column: "CircularId");

            migrationBuilder.CreateIndex(
                name: "IX_CircularCoordinators_CoordinatorId",
                table: "CircularCoordinators",
                column: "CoordinatorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CircularArbitrators");

            migrationBuilder.DropTable(
                name: "CircularAttachments");

            migrationBuilder.DropTable(
                name: "CircularChairmans");

            migrationBuilder.DropTable(
                name: "CircularCoordinators");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Circulars",
                newName: "EnglishTitle");

            migrationBuilder.RenameColumn(
                name: "CircularText",
                table: "Circulars",
                newName: "ArabicTitle");

            migrationBuilder.AddColumn<string>(
                name: "ArabicFileUrl",
                table: "Circulars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnglishFileUrl",
                table: "Circulars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6265), new DateTime(2024, 7, 4, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6272), new DateTime(2024, 6, 29, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6288) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6291), new DateTime(2024, 7, 9, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6294), new DateTime(2024, 7, 4, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6295) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6296), new DateTime(2024, 7, 14, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6299), new DateTime(2024, 7, 9, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6300) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6302), new DateTime(2024, 7, 19, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6304), new DateTime(2024, 7, 14, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6307), new DateTime(2024, 7, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6308), new DateTime(2024, 7, 19, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6309) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9472));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1406));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1410));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9268));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9287));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9300));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1134));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8275));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6903), new DateTime(2024, 6, 24, 16, 37, 40, 522, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7030), new DateTime(2024, 6, 24, 16, 37, 40, 522, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7047), new DateTime(2024, 6, 24, 16, 37, 40, 522, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7057), new DateTime(2024, 6, 24, 16, 37, 40, 522, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6767));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6838));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5699), new DateTime(2024, 6, 29, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5704), new DateTime(2024, 6, 26, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5717), new DateTime(2024, 6, 27, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5719) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5723), new DateTime(2024, 7, 2, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5724), new DateTime(2024, 6, 29, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5726), new DateTime(2024, 6, 30, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6520), new DateTime(2024, 7, 4, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6524) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6778), new DateTime(2024, 7, 14, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8820));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8985));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8989));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8993));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8560));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 520, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8004));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 523, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 24, 13, 37, 40, 522, DateTimeKind.Utc).AddTicks(6689));
        }
    }
}
