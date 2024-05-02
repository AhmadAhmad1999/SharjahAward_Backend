using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_Criterions_AddNewColumn_OrderId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Criterions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3373), new DateTime(2024, 5, 12, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3382), new DateTime(2024, 5, 7, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3395), new DateTime(2024, 5, 17, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3398), new DateTime(2024, 5, 12, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3402), new DateTime(2024, 5, 22, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3405), new DateTime(2024, 5, 17, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3408), new DateTime(2024, 5, 27, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3411), new DateTime(2024, 5, 22, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3415), new DateTime(2024, 6, 1, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3417), new DateTime(2024, 5, 27, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5903));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5913));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5922));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5927));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6032));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5813));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4075));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 21, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 21, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 21, DateTimeKind.Utc).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 21, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 21, DateTimeKind.Utc).AddTicks(1933), 0 });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 21, DateTimeKind.Utc).AddTicks(1945), 0 });

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 21, DateTimeKind.Utc).AddTicks(1951), 0 });

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6062));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6147));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4501), new DateTime(2024, 5, 2, 11, 11, 35, 22, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4638), new DateTime(2024, 5, 2, 11, 11, 35, 22, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4646), new DateTime(2024, 5, 2, 11, 11, 35, 22, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4653), new DateTime(2024, 5, 2, 11, 11, 35, 22, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5706));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4413));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3974), new DateTime(2024, 5, 7, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3978), new DateTime(2024, 5, 4, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3988), new DateTime(2024, 5, 5, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3990) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3992), new DateTime(2024, 5, 10, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3996), new DateTime(2024, 5, 7, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3998), new DateTime(2024, 5, 8, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5718));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(4983), new DateTime(2024, 5, 12, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(4988), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5226), new DateTime(2024, 5, 22, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5229), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4757));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3125));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3518));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 20, DateTimeKind.Utc).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4856));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4885));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3898));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5466));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 2, 8, 11, 35, 22, DateTimeKind.Utc).AddTicks(4232));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Criterions");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3789), new DateTime(2024, 5, 11, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3802), new DateTime(2024, 5, 6, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3815), new DateTime(2024, 5, 16, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3817), new DateTime(2024, 5, 11, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3819) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3838), new DateTime(2024, 5, 21, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3841), new DateTime(2024, 5, 16, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3842) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3844), new DateTime(2024, 5, 26, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3847), new DateTime(2024, 5, 21, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3848) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3850), new DateTime(2024, 5, 31, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3852), new DateTime(2024, 5, 26, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6027));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6029));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5958));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4485));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 196, DateTimeKind.Utc).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 196, DateTimeKind.Utc).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 196, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 196, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 196, DateTimeKind.Utc).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 196, DateTimeKind.Utc).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 196, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4979), new DateTime(2024, 5, 1, 13, 38, 5, 197, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(5078), new DateTime(2024, 5, 1, 13, 38, 5, 197, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(5086), new DateTime(2024, 5, 1, 13, 38, 5, 197, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(5093), new DateTime(2024, 5, 1, 13, 38, 5, 197, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(4404), new DateTime(2024, 5, 6, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(4408), new DateTime(2024, 5, 3, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(4418), new DateTime(2024, 5, 4, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(4419) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(4422), new DateTime(2024, 5, 9, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(4424), new DateTime(2024, 5, 6, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(4426), new DateTime(2024, 5, 7, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4400));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5788));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5266), new DateTime(2024, 5, 11, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5271), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5486), new DateTime(2024, 5, 21, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5490), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(4308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(4310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 195, DateTimeKind.Utc).AddTicks(4312));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4321));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 1, 10, 38, 5, 197, DateTimeKind.Utc).AddTicks(4609));
        }
    }
}
