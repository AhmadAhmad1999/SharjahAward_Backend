using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditeOnHomePageSliderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "HomePageSliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "HomePageSliders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7268), new DateTime(2024, 5, 7, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7271), new DateTime(2024, 5, 2, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7276), new DateTime(2024, 5, 12, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7278), new DateTime(2024, 5, 7, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7280), new DateTime(2024, 5, 17, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7282), new DateTime(2024, 5, 12, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7284), new DateTime(2024, 5, 22, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7285), new DateTime(2024, 5, 17, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7288), new DateTime(2024, 5, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7289), new DateTime(2024, 5, 22, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1286));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1183));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7447));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7601));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7786), new DateTime(2024, 4, 27, 16, 48, 51, 76, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7808), new DateTime(2024, 4, 27, 16, 48, 51, 76, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7810), new DateTime(2024, 4, 27, 16, 48, 51, 76, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7813), new DateTime(2024, 4, 27, 16, 48, 51, 76, DateTimeKind.Local).AddTicks(7814) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(300), new DateTime(2024, 5, 2, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(303), new DateTime(2024, 4, 29, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(310), new DateTime(2024, 4, 30, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(313), new DateTime(2024, 5, 5, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(315), new DateTime(2024, 5, 2, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(316), new DateTime(2024, 5, 3, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(806), new DateTime(2024, 5, 7, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(809), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(892), new DateTime(2024, 5, 17, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(894), "Friday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 75, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 75, DateTimeKind.Utc).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7647));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 27, 13, 48, 51, 76, DateTimeKind.Utc).AddTicks(7663));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "HomePageSliders");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "HomePageSliders");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2275), new DateTime(2024, 5, 5, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2278), new DateTime(2024, 4, 30, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2281) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2284), new DateTime(2024, 5, 10, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2285), new DateTime(2024, 5, 5, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2287), new DateTime(2024, 5, 15, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2289), new DateTime(2024, 5, 10, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2290) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2292), new DateTime(2024, 5, 20, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2293), new DateTime(2024, 5, 15, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2295), new DateTime(2024, 5, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2297), new DateTime(2024, 5, 20, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3630));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3634));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3517));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2749), new DateTime(2024, 4, 25, 16, 17, 30, 494, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2768), new DateTime(2024, 4, 25, 16, 17, 30, 494, DateTimeKind.Local).AddTicks(2769) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2770), new DateTime(2024, 4, 25, 16, 17, 30, 494, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2773), new DateTime(2024, 4, 25, 16, 17, 30, 494, DateTimeKind.Local).AddTicks(2774) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3332));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6071), new DateTime(2024, 4, 30, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6074), new DateTime(2024, 4, 27, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6083), new DateTime(2024, 4, 28, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6085), new DateTime(2024, 5, 3, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6087), new DateTime(2024, 4, 30, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6088), new DateTime(2024, 5, 1, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6088) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6715));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6717));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6482), new DateTime(2024, 5, 5, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6485), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6507), new DateTime(2024, 5, 15, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6509), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(5957));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 493, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3440));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3132));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3144));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 25, 13, 17, 30, 494, DateTimeKind.Utc).AddTicks(2590));
        }
    }
}
