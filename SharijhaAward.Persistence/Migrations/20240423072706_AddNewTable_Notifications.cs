using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable_Notifications : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishBody = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7748), new DateTime(2024, 5, 3, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7757), new DateTime(2024, 4, 28, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7768) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7774), new DateTime(2024, 5, 8, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7776), new DateTime(2024, 5, 3, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7781), new DateTime(2024, 5, 13, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7783), new DateTime(2024, 5, 8, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7787), new DateTime(2024, 5, 18, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7790), new DateTime(2024, 5, 13, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7794), new DateTime(2024, 5, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7797), new DateTime(2024, 5, 18, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3797));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 51, DateTimeKind.Utc).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 51, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 51, DateTimeKind.Utc).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 51, DateTimeKind.Utc).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 51, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 51, DateTimeKind.Utc).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 51, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(1253));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(1257));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(1263));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9127), new DateTime(2024, 4, 23, 9, 27, 1, 52, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9241), new DateTime(2024, 4, 23, 9, 27, 1, 52, DateTimeKind.Local).AddTicks(9244) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9252), new DateTime(2024, 4, 23, 9, 27, 1, 52, DateTimeKind.Local).AddTicks(9258) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9268), new DateTime(2024, 4, 23, 9, 27, 1, 52, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(1559), new DateTime(2024, 4, 28, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(1566), new DateTime(2024, 4, 25, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(1580), new DateTime(2024, 4, 26, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(1585), new DateTime(2024, 5, 1, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(1590), new DateTime(2024, 4, 28, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(1592), new DateTime(2024, 4, 29, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(2761), new DateTime(2024, 5, 3, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(2768), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3103), new DateTime(2024, 5, 13, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3108), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9396));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(737));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(7951));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 50, DateTimeKind.Utc).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9527));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(9538));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 53, DateTimeKind.Utc).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 23, 7, 27, 1, 52, DateTimeKind.Utc).AddTicks(8756));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8894), new DateTime(2024, 5, 2, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8903), new DateTime(2024, 4, 27, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8915), new DateTime(2024, 5, 7, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8917), new DateTime(2024, 5, 2, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 5, 12, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8923), new DateTime(2024, 5, 7, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8927), new DateTime(2024, 5, 17, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8929), new DateTime(2024, 5, 12, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8933), new DateTime(2024, 5, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8935), new DateTime(2024, 5, 17, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(140), new DateTime(2024, 4, 22, 11, 53, 17, 22, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(234), new DateTime(2024, 4, 22, 11, 53, 17, 22, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(242), new DateTime(2024, 4, 22, 11, 53, 17, 22, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(248), new DateTime(2024, 4, 22, 11, 53, 17, 22, DateTimeKind.Local).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9341), new DateTime(2024, 4, 27, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9345), new DateTime(2024, 4, 24, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9356), new DateTime(2024, 4, 25, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9361), new DateTime(2024, 4, 30, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9363), new DateTime(2024, 4, 27, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9365), new DateTime(2024, 4, 28, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(542), new DateTime(2024, 5, 2, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(547), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(812), new DateTime(2024, 5, 12, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(815), "Sunday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9789));
        }
    }
}
