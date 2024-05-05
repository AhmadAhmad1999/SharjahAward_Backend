using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_DynamicAttributes_AddNewColumns_ArabicTitle_EnglishTitle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArabicTitle",
                table: "DynamicAttributes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "EnglishTitle",
                table: "DynamicAttributes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(9865));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3166), new DateTime(2024, 5, 15, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3189), new DateTime(2024, 5, 10, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3215), new DateTime(2024, 5, 20, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3217), new DateTime(2024, 5, 15, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3219) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3221), new DateTime(2024, 5, 25, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3224), new DateTime(2024, 5, 20, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3228), new DateTime(2024, 5, 30, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3233), new DateTime(2024, 5, 25, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3239), new DateTime(2024, 6, 4, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3241), new DateTime(2024, 5, 30, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4189));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArabicTitle", "CreatedAt", "EnglishTitle" },
                values: new object[] { "اختبار نص 1", new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6341), "Test Text 1" });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArabicTitle", "CreatedAt", "EnglishTitle" },
                values: new object[] { "اختبار ايميل 1", new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6354), "Test Email 1" });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArabicTitle", "CreatedAt", "EnglishTitle" },
                values: new object[] { "اختبار صورة 1", new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6360), "Test Image 1" });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArabicTitle", "CreatedAt", "EnglishTitle" },
                values: new object[] { "اختبار ملف 1", new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6367), "Test File 1" });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArabicTitle", "CreatedAt", "EnglishTitle" },
                values: new object[] { "اختبار رقم متحرك 1", new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6372), "Test Phone Number 1" });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArabicTitle", "CreatedAt", "EnglishTitle" },
                values: new object[] { "اختبار رقم 1", new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6378), "Test Number 1" });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArabicTitle", "CreatedAt", "EnglishTitle" },
                values: new object[] { "اختبار تاريخ 1", new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6384), "Test Date 1" });

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArabicTitle", "CreatedAt", "EnglishTitle" },
                values: new object[] { "اختبار قائمة 1", new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6389), "Test List 1" });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4614), new DateTime(2024, 5, 5, 10, 47, 43, 852, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4751), new DateTime(2024, 5, 5, 10, 47, 43, 852, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4759), new DateTime(2024, 5, 5, 10, 47, 43, 852, DateTimeKind.Local).AddTicks(4762) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4767), new DateTime(2024, 5, 5, 10, 47, 43, 852, DateTimeKind.Local).AddTicks(4769) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5812));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5827));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5860));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8431), new DateTime(2024, 5, 10, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8440), new DateTime(2024, 5, 7, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8453), new DateTime(2024, 5, 8, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8454) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8458), new DateTime(2024, 5, 13, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8461), new DateTime(2024, 5, 10, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8463), new DateTime(2024, 5, 11, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(9463), new DateTime(2024, 5, 15, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(9470), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(9743), new DateTime(2024, 5, 25, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(9747), "Saturday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4904));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3426));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 850, DateTimeKind.Utc).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 849, DateTimeKind.Utc).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(6066));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4294));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 5, 7, 47, 43, 852, DateTimeKind.Utc).AddTicks(4322));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArabicTitle",
                table: "DynamicAttributes");

            migrationBuilder.DropColumn(
                name: "EnglishTitle",
                table: "DynamicAttributes");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7254), new DateTime(2024, 5, 12, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7258), new DateTime(2024, 5, 7, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7266), new DateTime(2024, 5, 17, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7268), new DateTime(2024, 5, 12, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7272), new DateTime(2024, 5, 22, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7274), new DateTime(2024, 5, 17, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7275) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7277), new DateTime(2024, 5, 27, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7279), new DateTime(2024, 5, 22, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7282), new DateTime(2024, 6, 1, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7284), new DateTime(2024, 5, 27, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6610));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6618));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6741));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9068));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8096), new DateTime(2024, 5, 2, 15, 33, 26, 29, DateTimeKind.Local).AddTicks(8102) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8117), new DateTime(2024, 5, 2, 15, 33, 26, 29, DateTimeKind.Local).AddTicks(8118) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8121), new DateTime(2024, 5, 2, 15, 33, 26, 29, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8125), new DateTime(2024, 5, 2, 15, 33, 26, 29, DateTimeKind.Local).AddTicks(8127) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8726));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5074), new DateTime(2024, 5, 7, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5080), new DateTime(2024, 5, 4, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5092), new DateTime(2024, 5, 5, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5096), new DateTime(2024, 5, 10, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5100), new DateTime(2024, 5, 7, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5103), new DateTime(2024, 5, 8, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5104) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7804));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5875), new DateTime(2024, 5, 12, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5883), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5915), new DateTime(2024, 5, 22, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(5919), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4989));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 28, DateTimeKind.Utc).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 12, 33, 26, 29, DateTimeKind.Utc).AddTicks(7942));
        }
    }
}
