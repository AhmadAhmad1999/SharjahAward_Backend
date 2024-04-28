using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTables_DarkCard_PageStructure_ParagraphCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3343), new DateTime(2024, 5, 8, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3351), new DateTime(2024, 5, 3, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3365), new DateTime(2024, 5, 13, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3368), new DateTime(2024, 5, 8, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3372), new DateTime(2024, 5, 18, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3375), new DateTime(2024, 5, 13, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3378), new DateTime(2024, 5, 23, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3380), new DateTime(2024, 5, 18, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3384), new DateTime(2024, 5, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3386), new DateTime(2024, 5, 23, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6766));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6769));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6778));

            migrationBuilder.InsertData(
                table: "AttributeDataTypes",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Name", "isDeleted" },
                values: new object[] { 9, new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6781), null, null, null, null, "Location", false });

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6899));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4020));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4432));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 766, DateTimeKind.Utc).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 766, DateTimeKind.Utc).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 766, DateTimeKind.Utc).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 766, DateTimeKind.Utc).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 766, DateTimeKind.Utc).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 766, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 766, DateTimeKind.Utc).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6384));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6493));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4834), new DateTime(2024, 4, 28, 17, 23, 1, 767, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4940), new DateTime(2024, 4, 28, 17, 23, 1, 767, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4948), new DateTime(2024, 4, 28, 17, 23, 1, 767, DateTimeKind.Local).AddTicks(4950) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4955), new DateTime(2024, 4, 28, 17, 23, 1, 767, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4648));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4365), new DateTime(2024, 5, 3, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4370), new DateTime(2024, 4, 30, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4382), new DateTime(2024, 5, 1, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4386), new DateTime(2024, 5, 6, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4389), new DateTime(2024, 5, 3, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4391), new DateTime(2024, 5, 4, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4392) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4324));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(5762), new DateTime(2024, 5, 8, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6022), new DateTime(2024, 5, 18, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5061));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 765, DateTimeKind.Utc).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5169));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5746));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4537));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 14, 23, 1, 767, DateTimeKind.Utc).AddTicks(4558));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6626), new DateTime(2024, 5, 8, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6642), new DateTime(2024, 5, 3, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6659), new DateTime(2024, 5, 13, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6664), new DateTime(2024, 5, 8, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6666) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6670), new DateTime(2024, 5, 18, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6674), new DateTime(2024, 5, 13, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6680), new DateTime(2024, 5, 23, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6685), new DateTime(2024, 5, 18, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6691), new DateTime(2024, 5, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6695), new DateTime(2024, 5, 23, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6697) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 236, DateTimeKind.Utc).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 236, DateTimeKind.Utc).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 236, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 236, DateTimeKind.Utc).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 236, DateTimeKind.Utc).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 236, DateTimeKind.Utc).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 236, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1452));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8496), new DateTime(2024, 4, 28, 11, 23, 26, 238, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8629), new DateTime(2024, 4, 28, 11, 23, 26, 238, DateTimeKind.Local).AddTicks(8633) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8644), new DateTime(2024, 4, 28, 11, 23, 26, 238, DateTimeKind.Local).AddTicks(8647) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8656), new DateTime(2024, 4, 28, 11, 23, 26, 238, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3677), new DateTime(2024, 5, 3, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3684), new DateTime(2024, 4, 30, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3699), new DateTime(2024, 5, 1, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3707), new DateTime(2024, 5, 6, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3712), new DateTime(2024, 5, 3, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3716), new DateTime(2024, 5, 4, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3718) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7668));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6440));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(5437), new DateTime(2024, 5, 8, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(5448) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(5812), new DateTime(2024, 5, 18, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(6151));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 235, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(950));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 239, DateTimeKind.Utc).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 28, 8, 23, 26, 238, DateTimeKind.Utc).AddTicks(8025));
        }
    }
}
