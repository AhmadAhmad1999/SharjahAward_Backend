using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddRewardTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Meetings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Rewards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RewardValue = table.Column<int>(type: "int", nullable: false),
                    ArabicRank = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishRank = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Rewards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rewards_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(327), new DateTime(2024, 5, 15, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(330), new DateTime(2024, 5, 10, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(334), new DateTime(2024, 5, 20, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(336), new DateTime(2024, 5, 15, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(338), new DateTime(2024, 5, 25, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(339), new DateTime(2024, 5, 20, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(341), new DateTime(2024, 5, 30, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(343), new DateTime(2024, 5, 25, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(345), new DateTime(2024, 6, 4, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(346), new DateTime(2024, 5, 30, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(347) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4289));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4330));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4385));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4244));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(601));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(812), new DateTime(2024, 5, 5, 15, 43, 45, 228, DateTimeKind.Local).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(830), new DateTime(2024, 5, 5, 15, 43, 45, 228, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(832), new DateTime(2024, 5, 5, 15, 43, 45, 228, DateTimeKind.Local).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(835), new DateTime(2024, 5, 5, 15, 43, 45, 228, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1293));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3541), new DateTime(2024, 5, 10, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3543), new DateTime(2024, 5, 7, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3552), new DateTime(2024, 5, 8, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3555), new DateTime(2024, 5, 13, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3557), new DateTime(2024, 5, 10, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3558), new DateTime(2024, 5, 11, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3955), new DateTime(2024, 5, 15, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3984), new DateTime(2024, 5, 25, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3985) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4109));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3452));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1109));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 12, 43, 45, 228, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.CreateIndex(
                name: "IX_Rewards_CategoryId",
                table: "Rewards",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rewards");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "Meetings",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(4978), new DateTime(2024, 5, 15, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(4987), new DateTime(2024, 5, 10, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(4998) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5002), new DateTime(2024, 5, 20, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5005), new DateTime(2024, 5, 15, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5007) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5010), new DateTime(2024, 5, 25, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5012), new DateTime(2024, 5, 20, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5067), new DateTime(2024, 5, 30, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5070), new DateTime(2024, 5, 25, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5075), new DateTime(2024, 6, 4, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5078), new DateTime(2024, 5, 30, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3161));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6097));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 856, DateTimeKind.Utc).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 856, DateTimeKind.Utc).AddTicks(3550));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 856, DateTimeKind.Utc).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 856, DateTimeKind.Utc).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 856, DateTimeKind.Utc).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 856, DateTimeKind.Utc).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 856, DateTimeKind.Utc).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8681));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6617), new DateTime(2024, 5, 5, 12, 12, 38, 858, DateTimeKind.Local).AddTicks(6625) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6728), new DateTime(2024, 5, 5, 12, 12, 38, 858, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6738), new DateTime(2024, 5, 5, 12, 12, 38, 858, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6750), new DateTime(2024, 5, 5, 12, 12, 38, 858, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9952), new DateTime(2024, 5, 10, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9961), new DateTime(2024, 5, 7, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9974), new DateTime(2024, 5, 8, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9980), new DateTime(2024, 5, 13, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9984), new DateTime(2024, 5, 10, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9987), new DateTime(2024, 5, 11, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9989) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(1675), new DateTime(2024, 5, 15, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2009), new DateTime(2024, 5, 25, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 855, DateTimeKind.Utc).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9757));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 854, DateTimeKind.Utc).AddTicks(9778));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7722));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7741));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 9, 12, 38, 858, DateTimeKind.Utc).AddTicks(6253));
        }
    }
}
