using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewIdentifierValueGeneratorStrategyFor_Arbitrators_Coordinators : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5495), new DateTime(2024, 4, 26, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5506), new DateTime(2024, 4, 21, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5524), new DateTime(2024, 5, 1, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5530), new DateTime(2024, 4, 26, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5533) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5537), new DateTime(2024, 5, 6, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5540), new DateTime(2024, 5, 1, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5543) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5546), new DateTime(2024, 5, 11, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5550), new DateTime(2024, 5, 6, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5552) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5556), new DateTime(2024, 5, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5559), new DateTime(2024, 5, 11, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5562) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7726));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7553));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 849, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 849, DateTimeKind.Utc).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 849, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 849, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 849, DateTimeKind.Utc).AddTicks(6060));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 849, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 849, DateTimeKind.Utc).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9380));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9557));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(7120), new DateTime(2024, 4, 16, 16, 43, 8, 851, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(7244), new DateTime(2024, 4, 16, 16, 43, 8, 851, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(7256), new DateTime(2024, 4, 16, 16, 43, 8, 851, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(7268), new DateTime(2024, 4, 16, 16, 43, 8, 851, DateTimeKind.Local).AddTicks(7272) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(4913), new DateTime(2024, 4, 21, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(4922), new DateTime(2024, 4, 18, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(4936), new DateTime(2024, 4, 19, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(4943), new DateTime(2024, 4, 24, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(4947), new DateTime(2024, 4, 21, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(4951), new DateTime(2024, 4, 22, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(4952) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(6405), new DateTime(2024, 4, 26, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(6413) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(6731), new DateTime(2024, 5, 6, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(7434));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(7617));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 14, 43, 8, 851, DateTimeKind.Utc).AddTicks(6729));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7285), new DateTime(2024, 4, 26, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7303), new DateTime(2024, 4, 21, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7323), new DateTime(2024, 5, 1, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7327), new DateTime(2024, 4, 26, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7333), new DateTime(2024, 5, 6, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7337), new DateTime(2024, 5, 1, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7339) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7343), new DateTime(2024, 5, 11, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7347), new DateTime(2024, 5, 6, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7353), new DateTime(2024, 5, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7358), new DateTime(2024, 5, 11, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9382));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9387));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9543));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9560));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8505));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 927, DateTimeKind.Utc).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 927, DateTimeKind.Utc).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 927, DateTimeKind.Utc).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 927, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 927, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 927, DateTimeKind.Utc).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 927, DateTimeKind.Utc).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(2136));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9166), new DateTime(2024, 4, 16, 15, 59, 9, 929, DateTimeKind.Local).AddTicks(9177) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9301), new DateTime(2024, 4, 16, 15, 59, 9, 929, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9315), new DateTime(2024, 4, 16, 15, 59, 9, 929, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9327), new DateTime(2024, 4, 16, 15, 59, 9, 929, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5090), new DateTime(2024, 4, 21, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5100), new DateTime(2024, 4, 18, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5114), new DateTime(2024, 4, 19, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5122), new DateTime(2024, 4, 24, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5127), new DateTime(2024, 4, 21, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5130), new DateTime(2024, 4, 22, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9070));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(9082));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(7915), new DateTime(2024, 4, 26, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(7925) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8310), new DateTime(2024, 5, 6, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8320) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(4924));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 926, DateTimeKind.Utc).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9687));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(9698));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 930, DateTimeKind.Utc).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 16, 13, 59, 9, 929, DateTimeKind.Utc).AddTicks(8754));
        }
    }
}
