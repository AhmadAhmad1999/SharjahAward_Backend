using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTable_Roles_AddNewColumn_HaveFullAccess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HaveFullAccess",
                table: "Roles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8894), new DateTime(2024, 5, 2, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8903), new DateTime(2024, 4, 27, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8915), new DateTime(2024, 5, 7, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8917), new DateTime(2024, 5, 2, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 5, 12, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8923), new DateTime(2024, 5, 7, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8927), new DateTime(2024, 5, 17, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8929), new DateTime(2024, 5, 12, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8933), new DateTime(2024, 5, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8935), new DateTime(2024, 5, 17, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1394));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1408));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1672));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(140), new DateTime(2024, 4, 22, 11, 53, 17, 22, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(234), new DateTime(2024, 4, 22, 11, 53, 17, 22, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(242), new DateTime(2024, 4, 22, 11, 53, 17, 22, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(248), new DateTime(2024, 4, 22, 11, 53, 17, 22, DateTimeKind.Local).AddTicks(251) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1284));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9341), new DateTime(2024, 4, 27, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9345), new DateTime(2024, 4, 24, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9356), new DateTime(2024, 4, 25, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9358) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9361), new DateTime(2024, 4, 30, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9363), new DateTime(2024, 4, 27, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9365), new DateTime(2024, 4, 28, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9366) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(542), new DateTime(2024, 5, 2, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(547) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(812), new DateTime(2024, 5, 12, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(352));

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "Id", "Content", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Slug", "Title", "isDeleted" },
                values: new object[,]
                {
                    { 1, "Content 1", new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(8811), null, null, null, null, "Slug 1", "Title 1", false },
                    { 2, "Content 2", new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(8819), null, null, null, null, "Slug 2", "Title 2", false }
                });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9055));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9060));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 20, DateTimeKind.Utc).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9251));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9254));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 19, DateTimeKind.Utc).AddTicks(9260));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "HaveFullAccess",
                value: false);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "HaveFullAccess",
                value: false);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "HaveFullAccess",
                value: false);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4,
                column: "HaveFullAccess",
                value: false);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 5,
                column: "HaveFullAccess",
                value: false);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 6,
                column: "HaveFullAccess",
                value: false);

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 22, DateTimeKind.Utc).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9779));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 9, 53, 17, 21, DateTimeKind.Utc).AddTicks(9789));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "HaveFullAccess",
                table: "Roles");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5077), new DateTime(2024, 5, 2, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5089), new DateTime(2024, 4, 27, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5105), new DateTime(2024, 5, 7, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5108), new DateTime(2024, 5, 2, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5112), new DateTime(2024, 5, 12, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5114), new DateTime(2024, 5, 7, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5118), new DateTime(2024, 5, 17, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5120), new DateTime(2024, 5, 12, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5124), new DateTime(2024, 5, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5126), new DateTime(2024, 5, 17, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3247));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3396));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5475));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5866));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5873));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(9420));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(9424));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(9250));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7910));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6283), new DateTime(2024, 4, 22, 10, 17, 13, 842, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6442), new DateTime(2024, 4, 22, 10, 17, 13, 842, DateTimeKind.Local).AddTicks(6444) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6451), new DateTime(2024, 4, 22, 10, 17, 13, 842, DateTimeKind.Local).AddTicks(6453) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6459), new DateTime(2024, 4, 22, 10, 17, 13, 842, DateTimeKind.Local).AddTicks(6463) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7494));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7510));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(715), new DateTime(2024, 4, 27, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(720), new DateTime(2024, 4, 24, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(734), new DateTime(2024, 4, 25, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(735) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(739), new DateTime(2024, 4, 30, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(742), new DateTime(2024, 4, 27, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(744), new DateTime(2024, 4, 28, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(745) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(2284), new DateTime(2024, 5, 2, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(2293) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(2557), new DateTime(2024, 5, 12, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(2560) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 839, DateTimeKind.Utc).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 840, DateTimeKind.Utc).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7253));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 8, 17, 13, 842, DateTimeKind.Utc).AddTicks(6015));
        }
    }
}
