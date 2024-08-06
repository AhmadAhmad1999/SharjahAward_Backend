using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationsBetweenCoordinatorAndEduEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstitutionCoordinators_Coordinators_CoordinatorId",
                table: "InstitutionCoordinators");

            migrationBuilder.DropForeignKey(
                name: "FK_InstitutionCoordinators_EducationalInstitutions_EducationalInstitutionId",
                table: "InstitutionCoordinators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstitutionCoordinators",
                table: "InstitutionCoordinators");

            migrationBuilder.RenameTable(
                name: "InstitutionCoordinators",
                newName: "EduInstitutionCoordinator");

            migrationBuilder.RenameIndex(
                name: "IX_InstitutionCoordinators_EducationalInstitutionId",
                table: "EduInstitutionCoordinator",
                newName: "IX_EduInstitutionCoordinator_EducationalInstitutionId");

            migrationBuilder.RenameIndex(
                name: "IX_InstitutionCoordinators_CoordinatorId",
                table: "EduInstitutionCoordinator",
                newName: "IX_EduInstitutionCoordinator_CoordinatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EduInstitutionCoordinator",
                table: "EduInstitutionCoordinator",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "EntitiesCoordinators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RelatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoordinatorId = table.Column<int>(type: "int", nullable: false),
                    EducationalEntityId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntitiesCoordinators", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntitiesCoordinators_Coordinators_CoordinatorId",
                        column: x => x.CoordinatorId,
                        principalTable: "Coordinators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntitiesCoordinators_EducationalEntities_EducationalEntityId",
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
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(541), new DateTime(2024, 8, 12, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(553), new DateTime(2024, 8, 16, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(552), new DateTime(2024, 8, 11, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(549) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(554), new DateTime(2024, 8, 18, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(558), new DateTime(2024, 8, 22, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(556), new DateTime(2024, 8, 17, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(559), new DateTime(2024, 8, 24, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(562), new DateTime(2024, 8, 28, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(560), new DateTime(2024, 8, 23, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(562) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(564), new DateTime(2024, 8, 30, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(567), new DateTime(2024, 9, 3, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(565), new DateTime(2024, 8, 29, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(566) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(568), new DateTime(2024, 9, 5, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(571), new DateTime(2024, 9, 9, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(569), new DateTime(2024, 9, 4, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(571) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3329));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "EduInstitutionCoordinator",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1039));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1428));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(890));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(751), new DateTime(2024, 8, 11, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(754), new DateTime(2024, 8, 8, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(762), new DateTime(2024, 8, 9, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(765), new DateTime(2024, 8, 14, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(766), new DateTime(2024, 8, 11, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(768), new DateTime(2024, 8, 12, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3453));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1287), new DateTime(2024, 8, 16, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1438), new DateTime(2024, 8, 26, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2014));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2027));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1832));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(87));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(193));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(222));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(287));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 728, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 12, 29, 48, 729, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.CreateIndex(
                name: "IX_EntitiesCoordinators_CoordinatorId",
                table: "EntitiesCoordinators",
                column: "CoordinatorId");

            migrationBuilder.CreateIndex(
                name: "IX_EntitiesCoordinators_EducationalEntityId",
                table: "EntitiesCoordinators",
                column: "EducationalEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_EduInstitutionCoordinator_Coordinators_CoordinatorId",
                table: "EduInstitutionCoordinator",
                column: "CoordinatorId",
                principalTable: "Coordinators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EduInstitutionCoordinator_EducationalInstitutions_EducationalInstitutionId",
                table: "EduInstitutionCoordinator",
                column: "EducationalInstitutionId",
                principalTable: "EducationalInstitutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EduInstitutionCoordinator_Coordinators_CoordinatorId",
                table: "EduInstitutionCoordinator");

            migrationBuilder.DropForeignKey(
                name: "FK_EduInstitutionCoordinator_EducationalInstitutions_EducationalInstitutionId",
                table: "EduInstitutionCoordinator");

            migrationBuilder.DropTable(
                name: "EntitiesCoordinators");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EduInstitutionCoordinator",
                table: "EduInstitutionCoordinator");

            migrationBuilder.RenameTable(
                name: "EduInstitutionCoordinator",
                newName: "InstitutionCoordinators");

            migrationBuilder.RenameIndex(
                name: "IX_EduInstitutionCoordinator_EducationalInstitutionId",
                table: "InstitutionCoordinators",
                newName: "IX_InstitutionCoordinators_EducationalInstitutionId");

            migrationBuilder.RenameIndex(
                name: "IX_EduInstitutionCoordinator_CoordinatorId",
                table: "InstitutionCoordinators",
                newName: "IX_InstitutionCoordinators_CoordinatorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstitutionCoordinators",
                table: "InstitutionCoordinators",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2265), new DateTime(2024, 8, 12, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2273), new DateTime(2024, 8, 16, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2272), new DateTime(2024, 8, 11, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2275), new DateTime(2024, 8, 18, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2278), new DateTime(2024, 8, 22, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2276), new DateTime(2024, 8, 17, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2279), new DateTime(2024, 8, 24, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2283), new DateTime(2024, 8, 28, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2281), new DateTime(2024, 8, 23, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2284), new DateTime(2024, 8, 30, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2287), new DateTime(2024, 9, 3, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2286), new DateTime(2024, 8, 29, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "CurrentDate", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2288), new DateTime(2024, 9, 5, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2292), new DateTime(2024, 9, 9, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2290), new DateTime(2024, 9, 4, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4251));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5143));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4292));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4296));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4298));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4150));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3122));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4360), new DateTime(2024, 8, 11, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4363), new DateTime(2024, 8, 8, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4371), new DateTime(2024, 8, 9, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4373), new DateTime(2024, 8, 14, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4374), new DateTime(2024, 8, 11, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4376), new DateTime(2024, 8, 12, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4392));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4395));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4399));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4992));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4815), new DateTime(2024, 8, 16, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4945), new DateTime(2024, 8, 26, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4947) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3370));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3386));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3403));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3808));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3176));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3217));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3231));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3235));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3815));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3823));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3834));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3838));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3856));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3860));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3862));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3873));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3892));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3896));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3919));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3926));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3945));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3967));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3971));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4009));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 100,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 101,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 102,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 103,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 104,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 105,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 106,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 107,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 108,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 109,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 110,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4035));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 111,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 112,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 113,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 114,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 115,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 116,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 117,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 118,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4050));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 119,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 120,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 121,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 122,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 123,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 124,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 125,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4063));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 126,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 127,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4067));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 128,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 129,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 130,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 131,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 132,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 133,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 134,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 135,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 136,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4084));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 137,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 138,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 139,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 140,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 141,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 142,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4095));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 143,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 144,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4105));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 145,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 146,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 147,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 148,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 149,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 150,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 151,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 152,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4120));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 153,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 154,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 155,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 156,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 157,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 158,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 159,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 160,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 161,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 162,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 163,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 164,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 165,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 166,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 167,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4147));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 168,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 169,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 170,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 171,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 172,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 173,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 174,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4160));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 175,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 176,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 177,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 178,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 179,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 180,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 181,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 182,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 183,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 184,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 185,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 186,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 187,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 188,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4186));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 189,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 190,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 48, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4334));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4337));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2969));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 8, 6, 11, 13, 56, 49, DateTimeKind.Utc).AddTicks(2457));

            migrationBuilder.AddForeignKey(
                name: "FK_InstitutionCoordinators_Coordinators_CoordinatorId",
                table: "InstitutionCoordinators",
                column: "CoordinatorId",
                principalTable: "Coordinators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InstitutionCoordinators_EducationalInstitutions_EducationalInstitutionId",
                table: "InstitutionCoordinators",
                column: "EducationalInstitutionId",
                principalTable: "EducationalInstitutions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
