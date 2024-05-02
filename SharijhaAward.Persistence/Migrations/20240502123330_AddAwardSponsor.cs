using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddAwardSponsor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AwardSponsors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpbringingAndAiography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HonoraryPositions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationalStages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Writings = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwardSponsors", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7254), new DateTime(2024, 5, 12, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7258), new DateTime(2024, 5, 7, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7266), new DateTime(2024, 5, 17, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7268), new DateTime(2024, 5, 12, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7272), new DateTime(2024, 5, 22, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7274), new DateTime(2024, 5, 17, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7277), new DateTime(2024, 5, 27, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7279), new DateTime(2024, 5, 22, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7282), new DateTime(2024, 6, 1, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7284), new DateTime(2024, 5, 27, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(9422), 1 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(9431), 2 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(9437), 1 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(9443), 2 });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(9335), 1 });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(9343), 1 });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(9349), 2 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9010), 1 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9068), 1 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9077), 2 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9081), 3 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9086), 4 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9091), 5 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9096), 6 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9100), 7 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9105), 8 });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8096), new DateTime(2024, 5, 2, 15, 33, 26, 29, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8117), new DateTime(2024, 5, 2, 15, 33, 26, 29, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8121), new DateTime(2024, 5, 2, 15, 33, 26, 29, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8125), new DateTime(2024, 5, 2, 15, 33, 26, 29, DateTimeKind.Local).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5074), new DateTime(2024, 5, 7, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5080), new DateTime(2024, 5, 4, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5092), new DateTime(2024, 5, 5, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5096), new DateTime(2024, 5, 10, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5100), new DateTime(2024, 5, 7, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 5, 8, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5875), new DateTime(2024, 5, 12, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5915), new DateTime(2024, 5, 22, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7942));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AwardSponsors");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4505), new DateTime(2024, 5, 12, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4515), new DateTime(2024, 5, 7, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4904), new DateTime(2024, 5, 17, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4907), new DateTime(2024, 5, 12, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4909) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4911), new DateTime(2024, 5, 22, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4914), new DateTime(2024, 5, 17, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4917), new DateTime(2024, 5, 27, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4920), new DateTime(2024, 5, 22, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4923), new DateTime(2024, 6, 1, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4925), new DateTime(2024, 5, 27, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(4927) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 424, DateTimeKind.Utc).AddTicks(2496), 0 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 424, DateTimeKind.Utc).AddTicks(2502), 0 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 424, DateTimeKind.Utc).AddTicks(2505), 0 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 424, DateTimeKind.Utc).AddTicks(2509), 0 });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 424, DateTimeKind.Utc).AddTicks(2390), 0 });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 424, DateTimeKind.Utc).AddTicks(2396), 0 });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 424, DateTimeKind.Utc).AddTicks(2400), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7966));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7726), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7814), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7824), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7829), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7835), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7840), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7844), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7848), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7852), 0 });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6310), new DateTime(2024, 5, 2, 14, 28, 51, 425, DateTimeKind.Local).AddTicks(6317) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6416), new DateTime(2024, 5, 2, 14, 28, 51, 425, DateTimeKind.Local).AddTicks(6418) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6423), new DateTime(2024, 5, 2, 14, 28, 51, 425, DateTimeKind.Local).AddTicks(6428) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6433), new DateTime(2024, 5, 2, 14, 28, 51, 425, DateTimeKind.Local).AddTicks(6434) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7332));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7354));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7366));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2428), new DateTime(2024, 5, 7, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2433), new DateTime(2024, 5, 4, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2444), new DateTime(2024, 5, 5, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2450), new DateTime(2024, 5, 10, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2453), new DateTime(2024, 5, 7, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2455), new DateTime(2024, 5, 8, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5141));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(3899), new DateTime(2024, 5, 12, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(3906) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4169), new DateTime(2024, 5, 22, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6520));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4476));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 423, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7467));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7088));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 11, 28, 51, 425, DateTimeKind.Utc).AddTicks(6034));
        }
    }
}
