using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditOnAcceptAchievement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAccepted",
                table: "Achievements",
                newName: "AcceptedOnSkillsAndExperiences");

            migrationBuilder.AddColumn<bool>(
                name: "AcceptedOnDistinctionField",
                table: "Achievements",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AcceptedOnProjects",
                table: "Achievements",
                type: "bit",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8320), new DateTime(2024, 5, 10, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8323), new DateTime(2024, 5, 5, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8327) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8329), new DateTime(2024, 5, 15, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8330), new DateTime(2024, 5, 10, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8332), new DateTime(2024, 5, 20, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8335), new DateTime(2024, 5, 15, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8337), new DateTime(2024, 5, 25, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8338), new DateTime(2024, 5, 20, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8339) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8370), new DateTime(2024, 5, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8371), new DateTime(2024, 5, 25, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8372) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(4005));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(3956));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8788), new DateTime(2024, 4, 30, 15, 11, 16, 183, DateTimeKind.Local).AddTicks(8793) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8804), new DateTime(2024, 4, 30, 15, 11, 16, 183, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8807), new DateTime(2024, 4, 30, 15, 11, 16, 183, DateTimeKind.Local).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8809), new DateTime(2024, 4, 30, 15, 11, 16, 183, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9370));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9375));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9376));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1656), new DateTime(2024, 5, 5, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1658), new DateTime(2024, 5, 2, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1665), new DateTime(2024, 5, 3, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1666) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1668), new DateTime(2024, 5, 8, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1669), new DateTime(2024, 5, 5, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1670), new DateTime(2024, 5, 6, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2306));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2092), new DateTime(2024, 5, 10, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2095) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2116), new DateTime(2024, 5, 20, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8998));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9231));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9237));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 12, 11, 16, 183, DateTimeKind.Utc).AddTicks(8669));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptedOnDistinctionField",
                table: "Achievements");

            migrationBuilder.DropColumn(
                name: "AcceptedOnProjects",
                table: "Achievements");

            migrationBuilder.RenameColumn(
                name: "AcceptedOnSkillsAndExperiences",
                table: "Achievements",
                newName: "IsAccepted");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7336), new DateTime(2024, 5, 10, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7345), new DateTime(2024, 5, 5, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7354) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7359), new DateTime(2024, 5, 15, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7360), new DateTime(2024, 5, 10, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7362) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7363), new DateTime(2024, 5, 20, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7366), new DateTime(2024, 5, 15, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7367) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7369), new DateTime(2024, 5, 25, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7371), new DateTime(2024, 5, 20, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7374), new DateTime(2024, 5, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7376), new DateTime(2024, 5, 25, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4914));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4923));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9710));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9713));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9716));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9718));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9721));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8350), new DateTime(2024, 4, 30, 14, 54, 5, 464, DateTimeKind.Local).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8375), new DateTime(2024, 4, 30, 14, 54, 5, 464, DateTimeKind.Local).AddTicks(8377) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8379), new DateTime(2024, 4, 30, 14, 54, 5, 464, DateTimeKind.Local).AddTicks(8380) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8382), new DateTime(2024, 4, 30, 14, 54, 5, 464, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9201));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9208));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9230));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9236));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9238));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9245));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3153), new DateTime(2024, 5, 5, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3160), new DateTime(2024, 5, 2, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3170), new DateTime(2024, 5, 3, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3174), new DateTime(2024, 5, 8, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3176), new DateTime(2024, 5, 5, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3177), new DateTime(2024, 5, 6, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4178), new DateTime(2024, 5, 10, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4184) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4383), new DateTime(2024, 5, 20, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4386) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3080));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 463, DateTimeKind.Utc).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9457));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9329));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8116));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 11, 54, 5, 464, DateTimeKind.Utc).AddTicks(8126));
        }
    }
}
