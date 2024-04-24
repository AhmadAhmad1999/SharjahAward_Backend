using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class add_Albums_Publications_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CycleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "Cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AwardPublications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutherDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CycleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardPublications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AwardPublications_Cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "Cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlbumId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Galleries_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalTable: "Albums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(255), new DateTime(2024, 5, 4, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(260), new DateTime(2024, 4, 29, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(269), new DateTime(2024, 5, 9, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(270), new DateTime(2024, 5, 4, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(273), new DateTime(2024, 5, 14, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(274), new DateTime(2024, 5, 9, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(275) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(277), new DateTime(2024, 5, 19, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(279), new DateTime(2024, 5, 14, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(281), new DateTime(2024, 5, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(283), new DateTime(2024, 5, 19, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(4860));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(4863));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(944), new DateTime(2024, 4, 24, 9, 38, 29, 745, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(964), new DateTime(2024, 4, 24, 9, 38, 29, 745, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(967), new DateTime(2024, 4, 24, 9, 38, 29, 745, DateTimeKind.Local).AddTicks(968) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(970), new DateTime(2024, 4, 24, 9, 38, 29, 745, DateTimeKind.Local).AddTicks(971) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1501));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(901));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2605), new DateTime(2024, 4, 29, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2608), new DateTime(2024, 4, 26, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2616), new DateTime(2024, 4, 27, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2617) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2619), new DateTime(2024, 5, 2, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2621), new DateTime(2024, 4, 29, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2622), new DateTime(2024, 4, 30, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3096), new DateTime(2024, 5, 4, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3099), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3122), new DateTime(2024, 5, 14, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3124), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 744, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1651));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 6, 38, 29, 745, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.CreateIndex(
                name: "IX_Albums_CycleId",
                table: "Albums",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_AwardPublications_CycleId",
                table: "AwardPublications",
                column: "CycleId");

            migrationBuilder.CreateIndex(
                name: "IX_Galleries_AlbumId",
                table: "Galleries",
                column: "AlbumId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AwardPublications");

            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(1983), new DateTime(2024, 5, 3, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(1993), new DateTime(2024, 4, 28, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2010), new DateTime(2024, 5, 8, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2013), new DateTime(2024, 5, 3, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2018), new DateTime(2024, 5, 13, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2021), new DateTime(2024, 5, 8, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2025), new DateTime(2024, 5, 18, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2029), new DateTime(2024, 5, 13, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2031) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2033), new DateTime(2024, 5, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2036), new DateTime(2024, 5, 18, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1601));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1758));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5510));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3435), new DateTime(2024, 4, 23, 12, 44, 0, 918, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3549), new DateTime(2024, 4, 23, 12, 44, 0, 918, DateTimeKind.Local).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3558), new DateTime(2024, 4, 23, 12, 44, 0, 918, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3567), new DateTime(2024, 4, 23, 12, 44, 0, 918, DateTimeKind.Local).AddTicks(3569) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4895));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4899));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(8888), new DateTime(2024, 4, 28, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(8894), new DateTime(2024, 4, 25, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(8905), new DateTime(2024, 4, 26, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(8911), new DateTime(2024, 5, 1, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(8915), new DateTime(2024, 4, 28, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(8918), new DateTime(2024, 4, 29, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(391), new DateTime(2024, 5, 3, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(397), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(704), new DateTime(2024, 5, 13, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(709), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3684));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(7526));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 916, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 915, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3806));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4585));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 10, 44, 0, 918, DateTimeKind.Utc).AddTicks(3121));
        }
    }
}
