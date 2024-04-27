using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Add_ReferenceSource_HomePageSlider_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AsignId",
                table: "EmailMessages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HomePageSliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePageSliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferenceSources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sources = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferenceSources", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2275), new DateTime(2024, 5, 5, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2278), new DateTime(2024, 4, 30, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2284), new DateTime(2024, 5, 10, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2285), new DateTime(2024, 5, 5, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2287), new DateTime(2024, 5, 15, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2289), new DateTime(2024, 5, 10, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2292), new DateTime(2024, 5, 20, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2293), new DateTime(2024, 5, 15, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2295), new DateTime(2024, 5, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2297), new DateTime(2024, 5, 20, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2749), new DateTime(2024, 4, 25, 16, 17, 30, 494, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2768), new DateTime(2024, 4, 25, 16, 17, 30, 494, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2770), new DateTime(2024, 4, 25, 16, 17, 30, 494, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2773), new DateTime(2024, 4, 25, 16, 17, 30, 494, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6071), new DateTime(2024, 4, 30, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6074), new DateTime(2024, 4, 27, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6083), new DateTime(2024, 4, 28, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6085), new DateTime(2024, 5, 3, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6087), new DateTime(2024, 4, 30, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6088), new DateTime(2024, 5, 1, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6482), new DateTime(2024, 5, 5, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6485), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6507), new DateTime(2024, 5, 15, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6509), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2590));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomePageSliders");

            migrationBuilder.DropTable(
                name: "ReferenceSources");

            migrationBuilder.DropColumn(
                name: "AsignId",
                table: "EmailMessages");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4729), new DateTime(2024, 5, 4, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4739), new DateTime(2024, 4, 29, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4746) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4749), new DateTime(2024, 5, 9, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4751), new DateTime(2024, 5, 4, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4754), new DateTime(2024, 5, 14, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4756), new DateTime(2024, 5, 9, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4814), new DateTime(2024, 5, 19, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4816), new DateTime(2024, 5, 14, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4820), new DateTime(2024, 5, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4822), new DateTime(2024, 5, 19, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 484, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 484, DateTimeKind.Utc).AddTicks(3013));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 484, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 484, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 484, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 484, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 484, DateTimeKind.Utc).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(8044));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5849), new DateTime(2024, 4, 24, 13, 53, 27, 485, DateTimeKind.Local).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5955), new DateTime(2024, 4, 24, 13, 53, 27, 485, DateTimeKind.Local).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5962), new DateTime(2024, 4, 24, 13, 53, 27, 485, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5968), new DateTime(2024, 4, 24, 13, 53, 27, 485, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7302));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(6110), new DateTime(2024, 4, 29, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(6115), new DateTime(2024, 4, 26, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(6126), new DateTime(2024, 4, 27, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(6131), new DateTime(2024, 5, 2, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(6133), new DateTime(2024, 4, 29, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(6135), new DateTime(2024, 4, 30, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(6970), new DateTime(2024, 5, 4, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(6976), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7223), new DateTime(2024, 5, 14, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7226), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 483, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 24, 11, 53, 27, 485, DateTimeKind.Utc).AddTicks(5605));
        }
    }
}
