using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddTable_Circulars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Circulars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishFileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArabicFileUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Circulars", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6869), new DateTime(2024, 4, 28, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6879), new DateTime(2024, 4, 23, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6889) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6893), new DateTime(2024, 5, 3, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6895), new DateTime(2024, 4, 28, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6899), new DateTime(2024, 5, 8, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6902), new DateTime(2024, 5, 3, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6906), new DateTime(2024, 5, 13, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6908), new DateTime(2024, 5, 8, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6911), new DateTime(2024, 5, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6914), new DateTime(2024, 5, 13, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(6579));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7658));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 833, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 833, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 833, DateTimeKind.Utc).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 833, DateTimeKind.Utc).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 833, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 833, DateTimeKind.Utc).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 833, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 836, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 836, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 836, DateTimeKind.Utc).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 836, DateTimeKind.Utc).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 836, DateTimeKind.Utc).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9800));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9929));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8118), new DateTime(2024, 4, 18, 13, 50, 9, 835, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8230), new DateTime(2024, 4, 18, 13, 50, 9, 835, DateTimeKind.Local).AddTicks(8232) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8238), new DateTime(2024, 4, 18, 13, 50, 9, 835, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8246), new DateTime(2024, 4, 18, 13, 50, 9, 835, DateTimeKind.Local).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9374));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9395));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5594), new DateTime(2024, 4, 23, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5599), new DateTime(2024, 4, 20, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5611), new DateTime(2024, 4, 21, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5615), new DateTime(2024, 4, 26, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5617), new DateTime(2024, 4, 23, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5619), new DateTime(2024, 4, 24, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5620) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(6687), new DateTime(2024, 4, 28, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(6692), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7037), new DateTime(2024, 5, 8, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7041), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5492));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5496));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 832, DateTimeKind.Utc).AddTicks(5499));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 11, 50, 9, 835, DateTimeKind.Utc).AddTicks(7801));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Circulars");

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
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 34, 2, 688, DateTimeKind.Utc).AddTicks(1343), new DateTime(2024, 4, 27, 13, 34, 2, 688, DateTimeKind.Utc).AddTicks(1350), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 17, 13, 34, 2, 688, DateTimeKind.Utc).AddTicks(1724), new DateTime(2024, 5, 7, 13, 34, 2, 688, DateTimeKind.Utc).AddTicks(1728), "Tuesday" });

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
        }
    }
}
