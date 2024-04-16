using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddTables_EmailMessages_EmailAttachmentsMessages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmailMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    To = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    MessageId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailMessages_EmailMessages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "EmailMessages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmailAttachments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttachmentUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MessageId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailAttachments_EmailMessages_MessageId",
                        column: x => x.MessageId,
                        principalTable: "EmailMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7867), new DateTime(2024, 4, 26, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7875), new DateTime(2024, 4, 21, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7885), new DateTime(2024, 5, 1, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7888), new DateTime(2024, 4, 26, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7889) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7891), new DateTime(2024, 5, 6, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7893), new DateTime(2024, 5, 1, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7895) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7897), new DateTime(2024, 5, 11, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7900), new DateTime(2024, 5, 6, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7903), new DateTime(2024, 5, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7907), new DateTime(2024, 5, 11, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2557));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9270), new DateTime(2024, 4, 16, 12, 59, 20, 94, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9364), new DateTime(2024, 4, 16, 12, 59, 20, 94, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9370), new DateTime(2024, 4, 16, 12, 59, 20, 94, DateTimeKind.Local).AddTicks(9372) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9376), new DateTime(2024, 4, 16, 12, 59, 20, 94, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(679), new DateTime(2024, 4, 21, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(687), new DateTime(2024, 4, 18, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(698), new DateTime(2024, 4, 19, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(702), new DateTime(2024, 4, 24, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(706), new DateTime(2024, 4, 21, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(708), new DateTime(2024, 4, 22, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(1830), new DateTime(2024, 4, 26, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2101), new DateTime(2024, 5, 6, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 93, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 95, DateTimeKind.Utc).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9524));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9931));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 10, 59, 20, 94, DateTimeKind.Utc).AddTicks(8782));

            migrationBuilder.CreateIndex(
                name: "IX_EmailAttachments_MessageId",
                table: "EmailAttachments",
                column: "MessageId");

            migrationBuilder.CreateIndex(
                name: "IX_EmailMessages_MessageId",
                table: "EmailMessages",
                column: "MessageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailAttachments");

            migrationBuilder.DropTable(
                name: "EmailMessages");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9266), new DateTime(2024, 4, 26, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9282), new DateTime(2024, 4, 21, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9302), new DateTime(2024, 5, 1, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9304), new DateTime(2024, 4, 26, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9307), new DateTime(2024, 5, 6, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9308), new DateTime(2024, 5, 1, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9311), new DateTime(2024, 5, 11, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9314), new DateTime(2024, 5, 6, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9316), new DateTime(2024, 5, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9318), new DateTime(2024, 5, 11, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9880));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(4640));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1289));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(160), new DateTime(2024, 4, 16, 10, 3, 44, 281, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(253), new DateTime(2024, 4, 16, 10, 3, 44, 281, DateTimeKind.Local).AddTicks(254) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(259), new DateTime(2024, 4, 16, 10, 3, 44, 281, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(264), new DateTime(2024, 4, 16, 10, 3, 44, 281, DateTimeKind.Local).AddTicks(266) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8784), new DateTime(2024, 4, 21, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8793), new DateTime(2024, 4, 18, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8802), new DateTime(2024, 4, 19, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8807), new DateTime(2024, 4, 24, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8809), new DateTime(2024, 4, 21, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8811), new DateTime(2024, 4, 22, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 278, DateTimeKind.Utc).AddTicks(9996), new DateTime(2024, 4, 26, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(2) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(229), new DateTime(2024, 5, 6, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(330));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(339));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 279, DateTimeKind.Utc).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1098));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 281, DateTimeKind.Utc).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 8, 3, 44, 280, DateTimeKind.Utc).AddTicks(9975));
        }
    }
}
