using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddTable_LogUserActions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogUserActions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ControllerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FunctionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BodyParameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HeaderParameters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResponseStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Result = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogUserActions", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogUserActions");

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
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3955), new DateTime(2024, 5, 15, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3959), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 5, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3984), new DateTime(2024, 5, 25, 12, 43, 45, 227, DateTimeKind.Utc).AddTicks(3985), "Saturday" });

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
        }
    }
}
