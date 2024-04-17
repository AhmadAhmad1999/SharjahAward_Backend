using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddTables_MessageTypes_RoleMessageTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "EmailMessages",
                newName: "TypeId");

            migrationBuilder.CreateTable(
                name: "MessageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleMessageTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageTypeId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_RoleMessageTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleMessageTypes_MessageTypes_MessageTypeId",
                        column: x => x.MessageTypeId,
                        principalTable: "MessageTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleMessageTypes_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 688, DateTimeKind.Utc).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7098), new DateTime(2024, 4, 27, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7106), new DateTime(2024, 4, 22, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7121), new DateTime(2024, 5, 2, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7124), new DateTime(2024, 4, 27, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7127), new DateTime(2024, 5, 7, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7129), new DateTime(2024, 5, 2, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7131) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7133), new DateTime(2024, 5, 12, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7135), new DateTime(2024, 5, 7, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7139), new DateTime(2024, 5, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7141), new DateTime(2024, 5, 12, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 688, DateTimeKind.Utc).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(8067));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 691, DateTimeKind.Utc).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 691, DateTimeKind.Utc).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 691, DateTimeKind.Utc).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 691, DateTimeKind.Utc).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 691, DateTimeKind.Utc).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 691, DateTimeKind.Utc).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 691, DateTimeKind.Utc).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8459), new DateTime(2024, 4, 17, 15, 34, 2, 692, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8568), new DateTime(2024, 4, 17, 15, 34, 2, 692, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8577), new DateTime(2024, 4, 17, 15, 34, 2, 692, DateTimeKind.Local).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8585), new DateTime(2024, 4, 17, 15, 34, 2, 692, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 34, 2, 687, DateTimeKind.Utc).AddTicks(7569), new DateTime(2024, 4, 22, 13, 34, 2, 687, DateTimeKind.Utc).AddTicks(7575), new DateTime(2024, 4, 19, 13, 34, 2, 687, DateTimeKind.Utc).AddTicks(7587), new DateTime(2024, 4, 20, 13, 34, 2, 687, DateTimeKind.Utc).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 34, 2, 687, DateTimeKind.Utc).AddTicks(7594), new DateTime(2024, 4, 25, 13, 34, 2, 687, DateTimeKind.Utc).AddTicks(7599), new DateTime(2024, 4, 22, 13, 34, 2, 687, DateTimeKind.Utc).AddTicks(7601), new DateTime(2024, 4, 23, 13, 34, 2, 687, DateTimeKind.Utc).AddTicks(7602) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7812));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 34, 2, 688, DateTimeKind.Utc).AddTicks(1343), new DateTime(2024, 4, 27, 13, 34, 2, 688, DateTimeKind.Utc).AddTicks(1350) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 34, 2, 688, DateTimeKind.Utc).AddTicks(1724), new DateTime(2024, 5, 7, 13, 34, 2, 688, DateTimeKind.Utc).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7299));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 690, DateTimeKind.Utc).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 687, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 687, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 687, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 687, DateTimeKind.Utc).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 687, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 687, DateTimeKind.Utc).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 693, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 13, 34, 2, 692, DateTimeKind.Utc).AddTicks(8065));

            migrationBuilder.CreateIndex(
                name: "IX_EmailMessages_TypeId",
                table: "EmailMessages",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMessageTypes_MessageTypeId",
                table: "RoleMessageTypes",
                column: "MessageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleMessageTypes_RoleId",
                table: "RoleMessageTypes",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailMessages_MessageTypes_TypeId",
                table: "EmailMessages",
                column: "TypeId",
                principalTable: "MessageTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailMessages_MessageTypes_TypeId",
                table: "EmailMessages");

            migrationBuilder.DropTable(
                name: "RoleMessageTypes");

            migrationBuilder.DropTable(
                name: "MessageTypes");

            migrationBuilder.DropIndex(
                name: "IX_EmailMessages_TypeId",
                table: "EmailMessages");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "EmailMessages",
                newName: "Type");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(792), new DateTime(2024, 4, 27, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(802), new DateTime(2024, 4, 22, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(813), new DateTime(2024, 5, 2, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(815), new DateTime(2024, 4, 27, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(817) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(819), new DateTime(2024, 5, 7, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(821), new DateTime(2024, 5, 2, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(824), new DateTime(2024, 5, 12, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(827), new DateTime(2024, 5, 7, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(830), new DateTime(2024, 5, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(832), new DateTime(2024, 5, 12, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1455));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 716, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 716, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 716, DateTimeKind.Utc).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 716, DateTimeKind.Utc).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 716, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 716, DateTimeKind.Utc).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 716, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3369));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3251));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1803), new DateTime(2024, 4, 17, 12, 40, 35, 717, DateTimeKind.Local).AddTicks(1813) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1903), new DateTime(2024, 4, 17, 12, 40, 35, 717, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1910), new DateTime(2024, 4, 17, 12, 40, 35, 717, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1916), new DateTime(2024, 4, 17, 12, 40, 35, 717, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(6398), new DateTime(2024, 4, 22, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(6403), new DateTime(2024, 4, 19, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(6413), new DateTime(2024, 4, 20, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(6417), new DateTime(2024, 4, 25, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(6419), new DateTime(2024, 4, 22, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(6421), new DateTime(2024, 4, 23, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7889));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7312), new DateTime(2024, 4, 27, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7317) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7551), new DateTime(2024, 5, 7, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7555) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(935));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7808));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 715, DateTimeKind.Utc).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 10, 40, 35, 717, DateTimeKind.Utc).AddTicks(1565));
        }
    }
}
