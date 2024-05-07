using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_EducationalInstitutions_AddColumns_EducationType_Emirates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ActivityId",
                table: "LogUserActions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "EducationType",
                table: "EducationalInstitutions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Emirates",
                table: "EducationalInstitutions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(7830), new DateTime(2024, 5, 17, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(7850), new DateTime(2024, 5, 12, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(7874), new DateTime(2024, 5, 22, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(7878), new DateTime(2024, 5, 17, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(7886), new DateTime(2024, 5, 27, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(7890), new DateTime(2024, 5, 22, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(7893) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(7896), new DateTime(2024, 6, 1, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(7900), new DateTime(2024, 5, 27, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(7906), new DateTime(2024, 6, 6, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(7910), new DateTime(2024, 6, 1, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 885, DateTimeKind.Utc).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 885, DateTimeKind.Utc).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 881, DateTimeKind.Utc).AddTicks(5618));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 881, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 881, DateTimeKind.Utc).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 881, DateTimeKind.Utc).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 881, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 881, DateTimeKind.Utc).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 881, DateTimeKind.Utc).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(4927));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(1546), new DateTime(2024, 5, 7, 16, 26, 54, 886, DateTimeKind.Local).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(1686), new DateTime(2024, 5, 7, 16, 26, 54, 886, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(1792), new DateTime(2024, 5, 7, 16, 26, 54, 886, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(1808), new DateTime(2024, 5, 7, 16, 26, 54, 886, DateTimeKind.Local).AddTicks(1811) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3894));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EducationType", "Emirates" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(1377), 0, 0 });

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EducationType", "Emirates" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(1386), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(6212), new DateTime(2024, 5, 12, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(6220), new DateTime(2024, 5, 9, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(6236), new DateTime(2024, 5, 10, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(6239) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(6247), new DateTime(2024, 5, 15, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(6251), new DateTime(2024, 5, 12, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(6255), new DateTime(2024, 5, 13, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 880, DateTimeKind.Utc).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(8606), new DateTime(2024, 5, 17, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(8617) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(9013), new DateTime(2024, 5, 27, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(9018) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(9346));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 884, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(9589));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(9419));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(4346));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3408));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(1065));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "LogUserActions");

            migrationBuilder.DropColumn(
                name: "EducationType",
                table: "EducationalInstitutions");

            migrationBuilder.DropColumn(
                name: "Emirates",
                table: "EducationalInstitutions");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4192), new DateTime(2024, 5, 17, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4198), new DateTime(2024, 5, 12, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4208), new DateTime(2024, 5, 22, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4211), new DateTime(2024, 5, 17, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4215), new DateTime(2024, 5, 27, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4217), new DateTime(2024, 5, 22, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4222), new DateTime(2024, 6, 1, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4225), new DateTime(2024, 5, 27, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4229), new DateTime(2024, 6, 6, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4232), new DateTime(2024, 6, 1, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(3897));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6777));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6792));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5349), new DateTime(2024, 5, 7, 14, 24, 54, 202, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5376), new DateTime(2024, 5, 7, 14, 24, 54, 202, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5381), new DateTime(2024, 5, 7, 14, 24, 54, 202, DateTimeKind.Local).AddTicks(5383) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5386), new DateTime(2024, 5, 7, 14, 24, 54, 202, DateTimeKind.Local).AddTicks(5388) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9305), new DateTime(2024, 5, 12, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9310), new DateTime(2024, 5, 9, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9321), new DateTime(2024, 5, 10, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9322) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9326), new DateTime(2024, 5, 15, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9329), new DateTime(2024, 5, 12, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9331), new DateTime(2024, 5, 13, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(168), new DateTime(2024, 5, 17, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(205), new DateTime(2024, 5, 27, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(208) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5459));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5463));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 201, DateTimeKind.Utc).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 200, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5960));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 11, 24, 54, 202, DateTimeKind.Utc).AddTicks(5107));
        }
    }
}
