using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddOrderByCreatedAtColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8387), new DateTime(2024, 4, 25, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8395), new DateTime(2024, 4, 20, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8405), new DateTime(2024, 4, 30, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8407), new DateTime(2024, 4, 25, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8411), new DateTime(2024, 5, 5, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8414), new DateTime(2024, 4, 30, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8415) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8417), new DateTime(2024, 5, 10, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8420), new DateTime(2024, 5, 5, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8424), new DateTime(2024, 5, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8426), new DateTime(2024, 5, 10, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8427) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1440));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1442));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9464), new DateTime(2024, 4, 15, 15, 25, 1, 516, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9565), new DateTime(2024, 4, 15, 15, 25, 1, 516, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9572), new DateTime(2024, 4, 15, 15, 25, 1, 516, DateTimeKind.Local).AddTicks(9574) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9579), new DateTime(2024, 4, 15, 15, 25, 1, 516, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(875));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9378));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9384));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1340), new DateTime(2024, 4, 20, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1353), new DateTime(2024, 4, 17, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1365), new DateTime(2024, 4, 18, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1367) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1369), new DateTime(2024, 4, 23, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1372), new DateTime(2024, 4, 20, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1374), new DateTime(2024, 4, 21, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3646));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3727));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3073), new DateTime(2024, 4, 25, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3311), new DateTime(2024, 5, 5, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 515, DateTimeKind.Utc).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(987));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9927));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(632));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 517, DateTimeKind.Utc).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9197));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 13, 25, 1, 516, DateTimeKind.Utc).AddTicks(9214));

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_CreatedAt",
                table: "UsersRoles",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatedAt",
                table: "Users",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWrokshopeAttachment_CreatedAt",
                table: "TrainingWrokshopeAttachment",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWorkshopSubscriber_CreatedAt",
                table: "TrainingWorkshopSubscribers",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingWorkshop_CreatedAt",
                table: "TrainingWorkshops",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_TermAndCondition_CreatedAt",
                table: "TermsAndConditions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Student_CreatedAt",
                table: "Students",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_StaticAttribute_CreatedAt",
                table: "StaticAttributes",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Scale_CreatedAt",
                table: "Scale",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Role_CreatedAt",
                table: "Roles",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_CreatedAt",
                table: "RolePermissions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccount_CreatedAt",
                table: "RelatedAccounts",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedAccountRequest_CreatedAt",
                table: "RelatedAccountRequests",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ProvidedForm_CreatedAt",
                table: "ProvidedForms",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInvitee_CreatedAt",
                table: "Personalnvitees",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Permission_CreatedAt",
                table: "Permissions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionHeader_CreatedAt",
                table: "PermissionHeaders",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_OurGoal_CreatedAt",
                table: "OurGoals",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_News_CreatedAt",
                table: "News",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_CreatedAt",
                table: "Meeting",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Interview_CreatedAt",
                table: "Interview",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Instruction_CreatedAt",
                table: "Instructions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_EduInstitutionCoordinator_CreatedAt",
                table: "InstitutionCoordinators",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_GroupInvitee_CreatedAt",
                table: "GroupInvitees",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralWorkshop_CreatedAt",
                table: "GeneralWorkshops",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralFAQ_CreatedAt",
                table: "GeneralFAQs",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralFAQCategory_CreatedAt",
                table: "GeneralFAQCategories",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_FrequentlyAskedQuestion_CreatedAt",
                table: "FrequentlyAskedQuestions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraAttachmentFile_CreatedAt",
                table: "ExtraAttachmentsProvidedForms",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ExtraAttachment_CreatedAt",
                table: "ExtraAttachments",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ExplanatoryGuide_CreatedAt",
                table: "ExplanatoryGuides",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Event_CreatedAt",
                table: "Events",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_EduEntitiesCoordinator_CreatedAt",
                table: "EducationCoordinators",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalInstitution_CreatedAt",
                table: "EducationalInstitutions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalEntity_CreatedAt",
                table: "EducationalEntities",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_EducationalClass_CreatedAt",
                table: "EducationalClasses",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributeValue_CreatedAt",
                table: "DynamicAttributeValues",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributeSection_CreatedAt",
                table: "DynamicAttributeSections",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttribute_CreatedAt",
                table: "DynamicAttributes",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributePatternValue_CreatedAt",
                table: "DynamicAttributePatternValues",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributePattern_CreatedAt",
                table: "DynamicAttributePatterns",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicAttributeListValue_CreatedAt",
                table: "DynamicAttributeListValues",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralValidation_CreatedAt",
                table: "DynamicAttributeGeneralValidations",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DependencyValidation_CreatedAt",
                table: "DependencyValidations",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_DependencyGroup_CreatedAt",
                table: "DependencyGroup",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Dependency_CreatedAt",
                table: "Dependencies",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Cycle_CreatedAt",
                table: "Cycles",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CycleConditionsProvidedForm_CreatedAt",
                table: "CycleConditionsProvidedForms",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CycleConditionAttachment_CreatedAt",
                table: "CycleConditionAttachments",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CycleCondition_CreatedAt",
                table: "CycleCondition",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Criterion_CreatedAt",
                table: "Criterions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItemScale_CreatedAt",
                table: "CriterionItemScales",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItem_CreatedAt",
                table: "CriterionItems",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionItemAttachment_CreatedAt",
                table: "CriterionItemAttachments",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CriterionAttachment_CreatedAt",
                table: "CriterionAttachments",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Coordinator_CreatedAt",
                table: "Coordinators",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionAttachment_CreatedAt",
                table: "ConditionAttachments",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Committee_CreatedAt",
                table: "Committees",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFAQ_CreatedAt",
                table: "CategoryFAQs",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryEducationalClass_CreatedAt",
                table: "CategoryEducationalClasses",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryCommittee_CreatedAt",
                table: "CategoryCommittees",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryArbitrator_CreatedAt",
                table: "CategoriesArbitrators",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CreatedAt",
                table: "Categories",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeTableName_CreatedAt",
                table: "AttributeTableNames",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeOperation_CreatedAt",
                table: "AttributeOperations",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AttributeDataType_CreatedAt",
                table: "AttributeDataTypes",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionsProvidedForms_CreatedAt",
                table: "Attachments",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Arbitrator_CreatedAt",
                table: "Arbitrators",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitratorClass_CreatedAt",
                table: "ArbitratorClasses",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_ArbitrationProcedure_CreatedAt",
                table: "ArbitrationProcedure",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AppVersion_CreatedAt",
                table: "AppVersions",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_CreatedAt",
                table: "Agendas",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_Achievement_CreatedAt",
                table: "Achievements",
                column: "CreatedAt");

            migrationBuilder.CreateIndex(
                name: "IX_AboutAwardPage_CreatedAt",
                table: "AboutAwardPage",
                column: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserRole_CreatedAt",
                table: "UsersRoles");

            migrationBuilder.DropIndex(
                name: "IX_User_CreatedAt",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_TrainingWrokshopeAttachment_CreatedAt",
                table: "TrainingWrokshopeAttachment");

            migrationBuilder.DropIndex(
                name: "IX_TrainingWorkshopSubscriber_CreatedAt",
                table: "TrainingWorkshopSubscribers");

            migrationBuilder.DropIndex(
                name: "IX_TrainingWorkshop_CreatedAt",
                table: "TrainingWorkshops");

            migrationBuilder.DropIndex(
                name: "IX_TermAndCondition_CreatedAt",
                table: "TermsAndConditions");

            migrationBuilder.DropIndex(
                name: "IX_Student_CreatedAt",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_StaticAttribute_CreatedAt",
                table: "StaticAttributes");

            migrationBuilder.DropIndex(
                name: "IX_Scale_CreatedAt",
                table: "Scale");

            migrationBuilder.DropIndex(
                name: "IX_Role_CreatedAt",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_RolePermission_CreatedAt",
                table: "RolePermissions");

            migrationBuilder.DropIndex(
                name: "IX_RelatedAccount_CreatedAt",
                table: "RelatedAccounts");

            migrationBuilder.DropIndex(
                name: "IX_RelatedAccountRequest_CreatedAt",
                table: "RelatedAccountRequests");

            migrationBuilder.DropIndex(
                name: "IX_ProvidedForm_CreatedAt",
                table: "ProvidedForms");

            migrationBuilder.DropIndex(
                name: "IX_PersonalInvitee_CreatedAt",
                table: "Personalnvitees");

            migrationBuilder.DropIndex(
                name: "IX_Permission_CreatedAt",
                table: "Permissions");

            migrationBuilder.DropIndex(
                name: "IX_PermissionHeader_CreatedAt",
                table: "PermissionHeaders");

            migrationBuilder.DropIndex(
                name: "IX_OurGoal_CreatedAt",
                table: "OurGoals");

            migrationBuilder.DropIndex(
                name: "IX_News_CreatedAt",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_CreatedAt",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Interview_CreatedAt",
                table: "Interview");

            migrationBuilder.DropIndex(
                name: "IX_Instruction_CreatedAt",
                table: "Instructions");

            migrationBuilder.DropIndex(
                name: "IX_EduInstitutionCoordinator_CreatedAt",
                table: "InstitutionCoordinators");

            migrationBuilder.DropIndex(
                name: "IX_GroupInvitee_CreatedAt",
                table: "GroupInvitees");

            migrationBuilder.DropIndex(
                name: "IX_GeneralWorkshop_CreatedAt",
                table: "GeneralWorkshops");

            migrationBuilder.DropIndex(
                name: "IX_GeneralFAQ_CreatedAt",
                table: "GeneralFAQs");

            migrationBuilder.DropIndex(
                name: "IX_GeneralFAQCategory_CreatedAt",
                table: "GeneralFAQCategories");

            migrationBuilder.DropIndex(
                name: "IX_FrequentlyAskedQuestion_CreatedAt",
                table: "FrequentlyAskedQuestions");

            migrationBuilder.DropIndex(
                name: "IX_ExtraAttachmentFile_CreatedAt",
                table: "ExtraAttachmentsProvidedForms");

            migrationBuilder.DropIndex(
                name: "IX_ExtraAttachment_CreatedAt",
                table: "ExtraAttachments");

            migrationBuilder.DropIndex(
                name: "IX_ExplanatoryGuide_CreatedAt",
                table: "ExplanatoryGuides");

            migrationBuilder.DropIndex(
                name: "IX_Event_CreatedAt",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_EduEntitiesCoordinator_CreatedAt",
                table: "EducationCoordinators");

            migrationBuilder.DropIndex(
                name: "IX_EducationalInstitution_CreatedAt",
                table: "EducationalInstitutions");

            migrationBuilder.DropIndex(
                name: "IX_EducationalEntity_CreatedAt",
                table: "EducationalEntities");

            migrationBuilder.DropIndex(
                name: "IX_EducationalClass_CreatedAt",
                table: "EducationalClasses");

            migrationBuilder.DropIndex(
                name: "IX_DynamicAttributeValue_CreatedAt",
                table: "DynamicAttributeValues");

            migrationBuilder.DropIndex(
                name: "IX_DynamicAttributeSection_CreatedAt",
                table: "DynamicAttributeSections");

            migrationBuilder.DropIndex(
                name: "IX_DynamicAttribute_CreatedAt",
                table: "DynamicAttributes");

            migrationBuilder.DropIndex(
                name: "IX_DynamicAttributePatternValue_CreatedAt",
                table: "DynamicAttributePatternValues");

            migrationBuilder.DropIndex(
                name: "IX_DynamicAttributePattern_CreatedAt",
                table: "DynamicAttributePatterns");

            migrationBuilder.DropIndex(
                name: "IX_DynamicAttributeListValue_CreatedAt",
                table: "DynamicAttributeListValues");

            migrationBuilder.DropIndex(
                name: "IX_GeneralValidation_CreatedAt",
                table: "DynamicAttributeGeneralValidations");

            migrationBuilder.DropIndex(
                name: "IX_DependencyValidation_CreatedAt",
                table: "DependencyValidations");

            migrationBuilder.DropIndex(
                name: "IX_DependencyGroup_CreatedAt",
                table: "DependencyGroup");

            migrationBuilder.DropIndex(
                name: "IX_Dependency_CreatedAt",
                table: "Dependencies");

            migrationBuilder.DropIndex(
                name: "IX_Cycle_CreatedAt",
                table: "Cycles");

            migrationBuilder.DropIndex(
                name: "IX_CycleConditionsProvidedForm_CreatedAt",
                table: "CycleConditionsProvidedForms");

            migrationBuilder.DropIndex(
                name: "IX_CycleConditionAttachment_CreatedAt",
                table: "CycleConditionAttachments");

            migrationBuilder.DropIndex(
                name: "IX_CycleCondition_CreatedAt",
                table: "CycleCondition");

            migrationBuilder.DropIndex(
                name: "IX_Criterion_CreatedAt",
                table: "Criterions");

            migrationBuilder.DropIndex(
                name: "IX_CriterionItemScale_CreatedAt",
                table: "CriterionItemScales");

            migrationBuilder.DropIndex(
                name: "IX_CriterionItem_CreatedAt",
                table: "CriterionItems");

            migrationBuilder.DropIndex(
                name: "IX_CriterionItemAttachment_CreatedAt",
                table: "CriterionItemAttachments");

            migrationBuilder.DropIndex(
                name: "IX_CriterionAttachment_CreatedAt",
                table: "CriterionAttachments");

            migrationBuilder.DropIndex(
                name: "IX_Coordinator_CreatedAt",
                table: "Coordinators");

            migrationBuilder.DropIndex(
                name: "IX_ConditionAttachment_CreatedAt",
                table: "ConditionAttachments");

            migrationBuilder.DropIndex(
                name: "IX_Committee_CreatedAt",
                table: "Committees");

            migrationBuilder.DropIndex(
                name: "IX_CategoryFAQ_CreatedAt",
                table: "CategoryFAQs");

            migrationBuilder.DropIndex(
                name: "IX_CategoryEducationalClass_CreatedAt",
                table: "CategoryEducationalClasses");

            migrationBuilder.DropIndex(
                name: "IX_CategoryCommittee_CreatedAt",
                table: "CategoryCommittees");

            migrationBuilder.DropIndex(
                name: "IX_CategoryArbitrator_CreatedAt",
                table: "CategoriesArbitrators");

            migrationBuilder.DropIndex(
                name: "IX_Category_CreatedAt",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_AttributeTableName_CreatedAt",
                table: "AttributeTableNames");

            migrationBuilder.DropIndex(
                name: "IX_AttributeOperation_CreatedAt",
                table: "AttributeOperations");

            migrationBuilder.DropIndex(
                name: "IX_AttributeDataType_CreatedAt",
                table: "AttributeDataTypes");

            migrationBuilder.DropIndex(
                name: "IX_ConditionsProvidedForms_CreatedAt",
                table: "Attachments");

            migrationBuilder.DropIndex(
                name: "IX_Arbitrator_CreatedAt",
                table: "Arbitrators");

            migrationBuilder.DropIndex(
                name: "IX_ArbitratorClass_CreatedAt",
                table: "ArbitratorClasses");

            migrationBuilder.DropIndex(
                name: "IX_ArbitrationProcedure_CreatedAt",
                table: "ArbitrationProcedure");

            migrationBuilder.DropIndex(
                name: "IX_AppVersion_CreatedAt",
                table: "AppVersions");

            migrationBuilder.DropIndex(
                name: "IX_Agenda_CreatedAt",
                table: "Agendas");

            migrationBuilder.DropIndex(
                name: "IX_Achievement_CreatedAt",
                table: "Achievements");

            migrationBuilder.DropIndex(
                name: "IX_AboutAwardPage_CreatedAt",
                table: "AboutAwardPage");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6071), new DateTime(2024, 4, 25, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6081), new DateTime(2024, 4, 20, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6095), new DateTime(2024, 4, 30, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6098), new DateTime(2024, 4, 25, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6100) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6102), new DateTime(2024, 5, 5, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6104), new DateTime(2024, 4, 30, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6106) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6108), new DateTime(2024, 5, 10, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6110), new DateTime(2024, 5, 5, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6112) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6114), new DateTime(2024, 5, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6116), new DateTime(2024, 5, 10, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5979));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6075));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6079));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 227, DateTimeKind.Utc).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 227, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 227, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 227, DateTimeKind.Utc).AddTicks(1489));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 227, DateTimeKind.Utc).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 227, DateTimeKind.Utc).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 227, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8704));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7152), new DateTime(2024, 4, 15, 12, 48, 35, 228, DateTimeKind.Local).AddTicks(7160) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7260), new DateTime(2024, 4, 15, 12, 48, 35, 228, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7268), new DateTime(2024, 4, 15, 12, 48, 35, 228, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7274), new DateTime(2024, 4, 15, 12, 48, 35, 228, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7000));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3412), new DateTime(2024, 4, 20, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3425), new DateTime(2024, 4, 17, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3443), new DateTime(2024, 4, 18, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3448), new DateTime(2024, 4, 23, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3452), new DateTime(2024, 4, 20, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3454), new DateTime(2024, 4, 21, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(3455) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5025), new DateTime(2024, 4, 25, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5275), new DateTime(2024, 5, 5, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7371));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 226, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6611));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6902));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 15, 10, 48, 35, 228, DateTimeKind.Utc).AddTicks(6919));
        }
    }
}
