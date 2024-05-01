using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_CriterionItems_AddNewColumn_OrderId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "CriterionItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 196, DateTimeKind.Utc).AddTicks(1925), 0 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 196, DateTimeKind.Utc).AddTicks(1930), 0 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 196, DateTimeKind.Utc).AddTicks(1935), 0 });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "OrderId" },
                values: new object[] { new DateTime(2024, 5, 1, 10, 38, 5, 196, DateTimeKind.Utc).AddTicks(1939), 0 });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "CriterionItems");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9357), new DateTime(2024, 5, 10, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9369), new DateTime(2024, 5, 5, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9386), new DateTime(2024, 5, 15, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9388), new DateTime(2024, 5, 10, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9393), new DateTime(2024, 5, 20, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9395), new DateTime(2024, 5, 15, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9399), new DateTime(2024, 5, 25, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9402), new DateTime(2024, 5, 20, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9448), new DateTime(2024, 5, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9452), new DateTime(2024, 5, 25, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 226, DateTimeKind.Utc).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 226, DateTimeKind.Utc).AddTicks(2378));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 226, DateTimeKind.Utc).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 226, DateTimeKind.Utc).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 226, DateTimeKind.Utc).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 226, DateTimeKind.Utc).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 226, DateTimeKind.Utc).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1022), new DateTime(2024, 4, 30, 16, 22, 10, 228, DateTimeKind.Local).AddTicks(1029) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1134), new DateTime(2024, 4, 30, 16, 22, 10, 228, DateTimeKind.Local).AddTicks(1136) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1143), new DateTime(2024, 4, 30, 16, 22, 10, 228, DateTimeKind.Local).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1150), new DateTime(2024, 4, 30, 16, 22, 10, 228, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2139));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2165));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3018), new DateTime(2024, 5, 5, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3023), new DateTime(2024, 5, 2, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3036), new DateTime(2024, 5, 3, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3041), new DateTime(2024, 5, 8, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3044), new DateTime(2024, 5, 5, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3045), new DateTime(2024, 5, 6, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5310));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(4570), new DateTime(2024, 5, 10, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(4579), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(4845), new DateTime(2024, 5, 20, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(4848), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1271));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 227, DateTimeKind.Utc).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 225, DateTimeKind.Utc).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(2357));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(110));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(438));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 30, 13, 22, 10, 228, DateTimeKind.Utc).AddTicks(456));
        }
    }
}
