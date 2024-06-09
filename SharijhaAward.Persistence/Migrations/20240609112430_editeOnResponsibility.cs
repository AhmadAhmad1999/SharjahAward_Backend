using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editeOnResponsibility : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responsibilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsibilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Responsibilities_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResponsibilitiesUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ResponsibilityId = table.Column<int>(type: "int", nullable: false),
                    IsAccept = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsibilitiesUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponsibilitiesUsers_Responsibilities_ResponsibilityId",
                        column: x => x.ResponsibilityId,
                        principalTable: "Responsibilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResponsibilitiesUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Responsibilities_RoleId",
                table: "Responsibilities",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibilitiesUsers_ResponsibilityId",
                table: "ResponsibilitiesUsers",
                column: "ResponsibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_ResponsibilitiesUsers_UserId",
                table: "ResponsibilitiesUsers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResponsibilitiesUsers");

            migrationBuilder.DropTable(
                name: "Responsibilities");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3241), new DateTime(2024, 6, 19, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3244), new DateTime(2024, 6, 14, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3249), new DateTime(2024, 6, 24, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3250), new DateTime(2024, 6, 19, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3252), new DateTime(2024, 6, 29, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3254), new DateTime(2024, 6, 24, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3256), new DateTime(2024, 7, 4, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3257), new DateTime(2024, 6, 29, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3260), new DateTime(2024, 7, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3261), new DateTime(2024, 7, 4, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3432));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3434));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3436));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3493));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3374));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5803));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5811));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3430));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5640));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4857));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4370));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4372));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4297));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3629), new DateTime(2024, 6, 9, 13, 20, 13, 768, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3653), new DateTime(2024, 6, 9, 13, 20, 13, 768, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3656), new DateTime(2024, 6, 9, 13, 20, 13, 768, DateTimeKind.Local).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3658), new DateTime(2024, 6, 9, 13, 20, 13, 768, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4090));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2572), new DateTime(2024, 6, 14, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2577), new DateTime(2024, 6, 11, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2583), new DateTime(2024, 6, 12, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2587), new DateTime(2024, 6, 17, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2588), new DateTime(2024, 6, 14, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2589), new DateTime(2024, 6, 15, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5923));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5925));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "ExplanatoryMessages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3092), new DateTime(2024, 6, 19, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3229), new DateTime(2024, 6, 29, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(3231) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3707));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4638));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4662));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4663));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4694));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5301));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4434));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4452));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4454));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4459));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 767, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5864));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5519));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3959));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 9, 10, 20, 13, 768, DateTimeKind.Utc).AddTicks(3511));
        }
    }
}
