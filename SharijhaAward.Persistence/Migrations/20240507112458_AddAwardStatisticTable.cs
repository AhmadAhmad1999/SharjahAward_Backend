using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddAwardStatisticTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AwardStatistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatisticValue = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_AwardStatistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AwardStatistics_Cycles_CycleId",
                        column: x => x.CycleId,
                        principalTable: "Cycles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4192), new DateTime(2024, 5, 17, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4198), new DateTime(2024, 5, 12, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4208), new DateTime(2024, 5, 22, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4211), new DateTime(2024, 5, 17, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4215), new DateTime(2024, 5, 27, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4217), new DateTime(2024, 5, 22, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 6, 1, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4225), new DateTime(2024, 5, 27, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4229), new DateTime(2024, 6, 6, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4232), new DateTime(2024, 6, 1, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5349), new DateTime(2024, 5, 7, 14, 24, 54, 202, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5376), new DateTime(2024, 5, 7, 14, 24, 54, 202, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5381), new DateTime(2024, 5, 7, 14, 24, 54, 202, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5386), new DateTime(2024, 5, 7, 14, 24, 54, 202, DateTimeKind.Local).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9305), new DateTime(2024, 5, 12, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9310), new DateTime(2024, 5, 9, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9321), new DateTime(2024, 5, 10, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9326), new DateTime(2024, 5, 15, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9329), new DateTime(2024, 5, 12, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9331), new DateTime(2024, 5, 13, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(168), new DateTime(2024, 5, 17, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(174), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(205), new DateTime(2024, 5, 27, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(208), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5107));

            migrationBuilder.CreateIndex(
                name: "IX_AwardStatistics_CycleId",
                table: "AwardStatistics",
                column: "CycleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AwardStatistics");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7769), new DateTime(2024, 5, 16, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7778), new DateTime(2024, 5, 11, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7796), new DateTime(2024, 5, 21, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7798), new DateTime(2024, 5, 16, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7802), new DateTime(2024, 5, 26, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7804), new DateTime(2024, 5, 21, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7806) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7808), new DateTime(2024, 5, 31, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7810), new DateTime(2024, 5, 26, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7811) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7814), new DateTime(2024, 6, 5, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7816), new DateTime(2024, 5, 31, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7817) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7954));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 272, DateTimeKind.Utc).AddTicks(5820));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 272, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 272, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 272, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 272, DateTimeKind.Utc).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 272, DateTimeKind.Utc).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 272, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8923), new DateTime(2024, 5, 6, 11, 35, 50, 273, DateTimeKind.Local).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9030), new DateTime(2024, 5, 6, 11, 35, 50, 273, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9037), new DateTime(2024, 5, 6, 11, 35, 50, 273, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9043), new DateTime(2024, 5, 6, 11, 35, 50, 273, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(5808), new DateTime(2024, 5, 11, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(5814), new DateTime(2024, 5, 8, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(5825), new DateTime(2024, 5, 9, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(5829), new DateTime(2024, 5, 14, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(5832), new DateTime(2024, 5, 11, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(5834), new DateTime(2024, 5, 12, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7731));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(6963), new DateTime(2024, 5, 16, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(6969), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7250), new DateTime(2024, 5, 26, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7253), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9151));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(4997));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 271, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 274, DateTimeKind.Utc).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9249));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 6, 8, 35, 50, 273, DateTimeKind.Utc).AddTicks(8667));
        }
    }
}
