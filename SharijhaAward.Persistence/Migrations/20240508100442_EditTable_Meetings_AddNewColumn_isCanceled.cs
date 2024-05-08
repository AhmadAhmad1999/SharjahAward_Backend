using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_Meetings_AddNewColumn_isCanceled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isCanceled",
                table: "Meetings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7239), new DateTime(2024, 5, 18, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7247), new DateTime(2024, 5, 13, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7254) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7257), new DateTime(2024, 5, 23, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7260), new DateTime(2024, 5, 18, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7261) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7264), new DateTime(2024, 5, 28, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7266), new DateTime(2024, 5, 23, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7267) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7270), new DateTime(2024, 6, 2, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7272), new DateTime(2024, 5, 28, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7274) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7276), new DateTime(2024, 6, 7, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7278), new DateTime(2024, 6, 2, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7279) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 311, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 311, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 311, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 311, DateTimeKind.Utc).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 311, DateTimeKind.Utc).AddTicks(5474));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 311, DateTimeKind.Utc).AddTicks(5483));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 311, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 313, DateTimeKind.Utc).AddTicks(95));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 313, DateTimeKind.Utc).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 313, DateTimeKind.Utc).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 313, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 313, DateTimeKind.Utc).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9999));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 313, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 313, DateTimeKind.Utc).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 313, DateTimeKind.Utc).AddTicks(15));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 313, DateTimeKind.Utc).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8389), new DateTime(2024, 5, 8, 13, 4, 37, 312, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8497), new DateTime(2024, 5, 8, 13, 4, 37, 312, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8505), new DateTime(2024, 5, 8, 13, 4, 37, 312, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8512), new DateTime(2024, 5, 8, 13, 4, 37, 312, DateTimeKind.Local).AddTicks(8514) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9485));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9488));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(5982), new DateTime(2024, 5, 13, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(5987), new DateTime(2024, 5, 10, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(5997), new DateTime(2024, 5, 11, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(6002), new DateTime(2024, 5, 16, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(6005), new DateTime(2024, 5, 13, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(6007), new DateTime(2024, 5, 14, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(6793), new DateTime(2024, 5, 18, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(6798), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7044), new DateTime(2024, 5, 28, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7047), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(5021));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7388));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(5872));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9624));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9709));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8697));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7817));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 10, 4, 37, 312, DateTimeKind.Utc).AddTicks(8143));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isCanceled",
                table: "Meetings");

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
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 7, 13, 26, 54, 886, DateTimeKind.Utc).AddTicks(1386));

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
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(8606), new DateTime(2024, 5, 17, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(8617), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 7, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(9013), new DateTime(2024, 5, 27, 13, 26, 54, 879, DateTimeKind.Utc).AddTicks(9018), "Monday" });

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
    }
}
