using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddStrategicPartner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StrategicPartners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StrategicPartners", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7926), new DateTime(2024, 5, 7, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7929), new DateTime(2024, 5, 2, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7934), new DateTime(2024, 5, 12, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7935), new DateTime(2024, 5, 7, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7937), new DateTime(2024, 5, 17, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7939), new DateTime(2024, 5, 12, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7941), new DateTime(2024, 5, 22, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7942), new DateTime(2024, 5, 17, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7945), new DateTime(2024, 5, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7946), new DateTime(2024, 5, 22, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1934));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9484));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8618), new DateTime(2024, 4, 27, 20, 11, 33, 641, DateTimeKind.Local).AddTicks(8624) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8637), new DateTime(2024, 4, 27, 20, 11, 33, 641, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8639), new DateTime(2024, 4, 27, 20, 11, 33, 641, DateTimeKind.Local).AddTicks(8640) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8642), new DateTime(2024, 4, 27, 20, 11, 33, 641, DateTimeKind.Local).AddTicks(8643) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9194));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9195));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9199));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9204));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1062), new DateTime(2024, 5, 2, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1065), new DateTime(2024, 4, 29, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1072), new DateTime(2024, 4, 30, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1074), new DateTime(2024, 5, 5, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1076), new DateTime(2024, 5, 2, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1077), new DateTime(2024, 5, 3, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1078) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1480), new DateTime(2024, 5, 7, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1504), new DateTime(2024, 5, 17, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9295));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 11, 33, 641, DateTimeKind.Utc).AddTicks(8366));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.DropTable(
                name: "StrategicPartners");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1499), new DateTime(2024, 5, 7, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1503), new DateTime(2024, 5, 2, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1506) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1508), new DateTime(2024, 5, 12, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1509), new DateTime(2024, 5, 7, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1510) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1511), new DateTime(2024, 5, 17, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1512), new DateTime(2024, 5, 12, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1514), new DateTime(2024, 5, 22, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1516), new DateTime(2024, 5, 17, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1518), new DateTime(2024, 5, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1519), new DateTime(2024, 5, 22, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1919), new DateTime(2024, 4, 27, 20, 7, 28, 824, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1936), new DateTime(2024, 4, 27, 20, 7, 28, 824, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1938), new DateTime(2024, 4, 27, 20, 7, 28, 824, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1941), new DateTime(2024, 4, 27, 20, 7, 28, 824, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2408));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5671), new DateTime(2024, 5, 2, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5674), new DateTime(2024, 4, 29, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5680), new DateTime(2024, 4, 30, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5684), new DateTime(2024, 5, 5, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5686), new DateTime(2024, 5, 2, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5687), new DateTime(2024, 5, 3, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5687) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6038), new DateTime(2024, 5, 7, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6041) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6061), new DateTime(2024, 5, 17, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6063) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 823, DateTimeKind.Utc).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 17, 7, 28, 824, DateTimeKind.Utc).AddTicks(1817));
        }
    }
}
