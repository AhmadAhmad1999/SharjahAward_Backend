using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewIdentifierValueGeneratorStrategyFor_Arbitrators_Coordinators2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9340), new DateTime(2024, 4, 27, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9347), new DateTime(2024, 4, 22, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9355) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9357), new DateTime(2024, 5, 2, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9360), new DateTime(2024, 4, 27, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9363), new DateTime(2024, 5, 7, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9365), new DateTime(2024, 5, 2, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9368), new DateTime(2024, 5, 12, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9369), new DateTime(2024, 5, 7, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9371) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9372), new DateTime(2024, 5, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9375), new DateTime(2024, 5, 12, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4888));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4892));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4897));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(5014));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4795));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4802));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9689));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(300), new DateTime(2024, 4, 17, 11, 50, 4, 434, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(395), new DateTime(2024, 4, 17, 11, 50, 4, 434, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(401), new DateTime(2024, 4, 17, 11, 50, 4, 434, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(406), new DateTime(2024, 4, 17, 11, 50, 4, 434, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(3042), new DateTime(2024, 4, 22, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(3048), new DateTime(2024, 4, 19, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(3058), new DateTime(2024, 4, 20, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(3062), new DateTime(2024, 4, 25, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(3065), new DateTime(2024, 4, 22, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(3067), new DateTime(2024, 4, 23, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9898));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(3956), new DateTime(2024, 4, 27, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(3963) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4238), new DateTime(2024, 5, 7, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4241) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9482));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 432, DateTimeKind.Utc).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 433, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(1656));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 50, 4, 434, DateTimeKind.Utc).AddTicks(83));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2588), new DateTime(2024, 4, 27, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2602), new DateTime(2024, 4, 22, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2618), new DateTime(2024, 5, 2, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2620), new DateTime(2024, 4, 27, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2624), new DateTime(2024, 5, 7, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2627), new DateTime(2024, 5, 2, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2631), new DateTime(2024, 5, 12, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2634), new DateTime(2024, 5, 7, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2637), new DateTime(2024, 5, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2640), new DateTime(2024, 5, 12, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3976), new DateTime(2024, 4, 17, 11, 37, 45, 894, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4103), new DateTime(2024, 4, 17, 11, 37, 45, 894, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4112), new DateTime(2024, 4, 17, 11, 37, 45, 894, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4119), new DateTime(2024, 4, 17, 11, 37, 45, 894, DateTimeKind.Local).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8892), new DateTime(2024, 4, 22, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8898), new DateTime(2024, 4, 19, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8914), new DateTime(2024, 4, 20, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8920), new DateTime(2024, 4, 25, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8923), new DateTime(2024, 4, 22, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8925), new DateTime(2024, 4, 23, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(544), new DateTime(2024, 4, 27, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(550) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(881), new DateTime(2024, 5, 7, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3669));
        }
    }
}
