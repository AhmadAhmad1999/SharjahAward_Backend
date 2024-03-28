﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditEducationalEntityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "EducationalEntities",
                newName: "EnglishName");

            migrationBuilder.AddColumn<string>(
                name: "ArabicName",
                table: "EducationalEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6293), new DateTime(2024, 4, 27, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6298), new DateTime(2024, 4, 22, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6302) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6275), new DateTime(2024, 4, 22, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6280), new DateTime(2024, 4, 17, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6283) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6258), new DateTime(2024, 4, 17, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6262), new DateTime(2024, 4, 12, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6237), new DateTime(2024, 4, 12, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6242), new DateTime(2024, 4, 7, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6246) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6195), new DateTime(2024, 4, 7, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6208), new DateTime(2024, 4, 2, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 566, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 566, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 566, DateTimeKind.Utc).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 566, DateTimeKind.Utc).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 566, DateTimeKind.Utc).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 566, DateTimeKind.Utc).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 566, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2243));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2254));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8706), new DateTime(2024, 3, 28, 16, 7, 22, 568, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8874), new DateTime(2024, 3, 28, 16, 7, 22, 568, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8901), new DateTime(2024, 3, 28, 16, 7, 22, 568, DateTimeKind.Local).AddTicks(8909) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8928), new DateTime(2024, 3, 28, 16, 7, 22, 568, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "جهة تعليمية 2", new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8259) });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "ArabicName", "CreatedAt" },
                values: new object[] { "جهة تعليمية 1", new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3764), new DateTime(2024, 4, 2, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3807), new DateTime(2024, 3, 30, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3821), new DateTime(2024, 3, 31, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3825) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3830), new DateTime(2024, 4, 5, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3839), new DateTime(2024, 4, 2, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3842), new DateTime(2024, 4, 3, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(3845) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8290));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "Time" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(6954), new DateTime(2024, 4, 7, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(6969), "14:07:22.5657294" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "Time" },
                values: new object[] { new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(7350), new DateTime(2024, 4, 17, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(7360), "14:07:22.5657371" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9186));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9246));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 565, DateTimeKind.Utc).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9515));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9562));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 568, DateTimeKind.Utc).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 14, 7, 22, 569, DateTimeKind.Utc).AddTicks(919));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArabicName",
                table: "EducationalEntities");

            migrationBuilder.RenameColumn(
                name: "EnglishName",
                table: "EducationalEntities",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(843), new DateTime(2024, 4, 27, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(844), new DateTime(2024, 4, 22, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(846) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(838), new DateTime(2024, 4, 22, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(839), new DateTime(2024, 4, 17, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(832), new DateTime(2024, 4, 17, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(833), new DateTime(2024, 4, 12, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(827), new DateTime(2024, 4, 12, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(828), new DateTime(2024, 4, 7, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(815), new DateTime(2024, 4, 7, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(819), new DateTime(2024, 4, 2, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(823) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5323));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5291));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(6664));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1936));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1948));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1330), new DateTime(2024, 3, 28, 14, 23, 47, 763, DateTimeKind.Local).AddTicks(1336) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1347), new DateTime(2024, 3, 28, 14, 23, 47, 763, DateTimeKind.Local).AddTicks(1349) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1351), new DateTime(2024, 3, 28, 14, 23, 47, 763, DateTimeKind.Local).AddTicks(1353) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1356), new DateTime(2024, 3, 28, 14, 23, 47, 763, DateTimeKind.Local).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1264));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(4321), new DateTime(2024, 4, 2, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(4342), new DateTime(2024, 3, 30, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(4349), new DateTime(2024, 3, 31, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(4351), new DateTime(2024, 4, 5, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(4354), new DateTime(2024, 4, 2, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(4355), new DateTime(2024, 4, 3, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(4355) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1113));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "Time" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(4949), new DateTime(2024, 4, 7, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(4953), "11:23:47.7624969" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "Time" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(4988), new DateTime(2024, 4, 17, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(4992), "11:23:47.7624999" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1398));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1401));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5125));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 762, DateTimeKind.Utc).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1084));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1744));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1719));
        }
    }
}
