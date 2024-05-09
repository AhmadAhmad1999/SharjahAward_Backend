using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTables_Instructions_EditColumn_Content_Users_AddColumn_Token : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Instructions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5265), new DateTime(2024, 5, 18, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5277), new DateTime(2024, 5, 13, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5292) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5295), new DateTime(2024, 5, 23, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5297), new DateTime(2024, 5, 18, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5299) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5301), new DateTime(2024, 5, 28, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5303), new DateTime(2024, 5, 23, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5307), new DateTime(2024, 6, 2, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5310), new DateTime(2024, 5, 28, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5311) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5313), new DateTime(2024, 6, 7, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5317), new DateTime(2024, 6, 2, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5318) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2055));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 502, DateTimeKind.Utc).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 502, DateTimeKind.Utc).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 502, DateTimeKind.Utc).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 502, DateTimeKind.Utc).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 502, DateTimeKind.Utc).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 502, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 502, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6788), new DateTime(2024, 5, 8, 16, 56, 18, 504, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6916), new DateTime(2024, 5, 8, 16, 56, 18, 504, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6925), new DateTime(2024, 5, 8, 16, 56, 18, 504, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6931), new DateTime(2024, 5, 8, 16, 56, 18, 504, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6604));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9863), new DateTime(2024, 5, 13, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9868), new DateTime(2024, 5, 10, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9879), new DateTime(2024, 5, 11, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9884), new DateTime(2024, 5, 16, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9888), new DateTime(2024, 5, 13, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9890), new DateTime(2024, 5, 14, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1684));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(831), new DateTime(2024, 5, 18, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1172), new DateTime(2024, 5, 28, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1177) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedAt", "Slug", "Title" },
                values: new object[] { null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8550), "events_index", "جدول الفعاليات" });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedAt", "Slug", "Title" },
                values: new object[] { null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8556), "event_attendees_index", "جدول حضور الفعاليات" });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "Id", "Content", "CreatedAt", "CreatedBy", "DeletedAt", "LastModifiedAt", "LastModifiedBy", "Slug", "Title", "isDeleted" },
                values: new object[,]
                {
                    { 3, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8559), null, null, null, null, "arbitrators_index", "جدول المًحكّمين", false },
                    { 4, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8562), null, null, null, null, "coordinators_index", "جدول المًنسقين", false },
                    { 5, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8566), null, null, null, null, "arbitrator_form", "إضافة أو تعديل معلومات مًحكّم", false },
                    { 6, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8569), null, null, null, null, "coordinator_form", "إضافة أو تعديل معلومات مًنسق", false },
                    { 7, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8572), null, null, null, null, "class_arbitrators_index", "جدول مًحكّمين الصف", false },
                    { 8, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8575), null, null, null, null, "class_form", "إضافة أو تعديل معلومات صف", false },
                    { 9, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8579), null, null, null, null, "classes_index", "جدول الصفوف", false },
                    { 10, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8582), null, null, null, null, "cycle_form", "إضافة أو تعديل معلومات دورة", false },
                    { 11, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8586), null, null, null, null, "cycles_index", "جدول الدورات", false },
                    { 12, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8589), null, null, null, null, "Agendas_index", "جدول الأجندة", false },
                    { 13, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8595), null, null, null, null, "categories_index", "جدول الفئات الرئيسية مع الفئات الفرعية التابعة له", false },
                    { 14, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8599), null, null, null, null, "subcategory_form", "إضافة أو تعديل معلومات فئة فرعية", false },
                    { 15, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8602), null, null, null, null, "cycle_specifications_form", "إضافة أو تعديل محددات الدورة", false },
                    { 16, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8605), null, null, null, null, "explanatory_guide", "عرض الدليل التفسيري مع الإجراءات الممكنة", false },
                    { 17, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8613), null, null, null, null, "faq_index", "جدول الأسئلة الشائعة", false },
                    { 18, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8617), null, null, null, null, "cycle_conditions_index", "جدول الشروط العامة للدورة", false },
                    { 19, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8620), null, null, null, null, "data_import", "صفحة استيراد المعلومات", false },
                    { 20, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8623), null, null, null, null, "subcategory_conditions_index", "جدول شروط الفئة الفرعية", false },
                    { 21, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8627), null, null, null, null, "subcategory_fields_index", "جدول حقول الفئة الفرعية", false },
                    { 22, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8630), null, null, null, null, "subcategory_workshops_index", "جدول الورشات التدريبية للفئة الفرعية", false },
                    { 23, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8633), null, null, null, null, "educational_entities_index", "جدول الجهات التعليمية", false },
                    { 24, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8636), null, null, null, null, "educational_entities_form", "إضافة أو تعديل جهة تعليمية مع عرض المؤسسات التابعة في حال التعديل", false },
                    { 25, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8639), null, null, null, null, "educational_institution_form", "إضافة أو تعديل مؤسسة تعليمية", false },
                    { 26, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8642), null, null, null, null, "home", "الصفحة الرئيسية", false },
                    { 27, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8645), null, null, null, null, "instructions_index", "جدول الإرشادات", false },
                    { 28, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8650), null, null, null, null, "instruction_form", "صفحة تعديل إرشاد", false },
                    { 29, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8653), null, null, null, null, "notifications_index", "جدول الإشعارات", false },
                    { 30, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8657), null, null, null, null, "notifications_form", "إضافة إشعار", false },
                    { 31, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8660), null, null, null, null, "roles_index", "جدول الأدوار", false },
                    { 32, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8663), null, null, null, null, "role_form", "إضافة أو تعديل دور", false },
                    { 33, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8669), null, null, null, null, "subscribers_accounts_index", "جدول حسابات المشتركين", false },
                    { 34, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8673), null, null, null, null, "users_index", "جدول المستخدمين", false },
                    { 35, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8676), null, null, null, null, "user_form", "إضافة أو تعديل معلومات مستخدم", false },
                    { 36, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8679), null, null, null, null, "notifications_templates_index", "جدول نماذج الإشعارات", false },
                    { 37, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8683), null, null, null, null, "notification_template_form", "إضافة أو تعديل نموذج إشعارات", false },
                    { 38, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8686), null, null, null, null, "contact_us_index", "جدول طلبات التواصل", false },
                    { 39, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8690), null, null, null, null, "contact_us_details", "تفاصيل طلب تواصل", false },
                    { 40, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8693), null, null, null, null, "committees_index", "جدول اللجان", false },
                    { 41, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8697), null, null, null, null, "committee_form", "إضافة أو تعديل لجنة", false },
                    { 42, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8701), null, null, null, null, "meetings_index", "جدول الاجتماعات", false },
                    { 43, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8704), null, null, null, null, "meeting_form", "إضافة اجتماع", false },
                    { 44, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8707), null, null, null, null, "circulars_index", "جدول التعاميم", false },
                    { 45, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8710), null, null, null, null, "circular_form", "إضافة أو تعديل تعميم", false },
                    { 46, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8714), null, null, null, null, "general_workshops_index", "جدول الورشات التدريبية العامة", false },
                    { 47, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8717), null, null, null, null, "general_workshops_form", "إضافة أو تعديل ورشة تدريبية عامة", false },
                    { 48, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8720), null, null, null, null, "app_versions_index", "جدول نسخ التطبيق", false },
                    { 49, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8723), null, null, null, null, "app_version_form", "إضافة نسخة تطبيق", false },
                    { 50, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8726), null, null, null, null, "subscribers_profiles_index", "جدول برفايلات المستخدمين", false },
                    { 51, null, new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8729), null, null, null, null, "subscriber_profile", "بروفايل مستخدم", false }
                });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5449));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 501, DateTimeKind.Utc).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 500, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Token" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7549), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Token" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7557), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Token" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7561), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Token" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7566), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Token" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7571), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Token" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(7579), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Token" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6226), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Token" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6237), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Token" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6242), null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Token" },
                values: new object[] { new DateTime(2024, 5, 8, 13, 56, 18, 504, DateTimeKind.Utc).AddTicks(6284), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Instructions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(6793), new DateTime(2024, 5, 18, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7044), new DateTime(2024, 5, 28, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(7047) });

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
                columns: new[] { "Content", "CreatedAt", "Slug", "Title" },
                values: new object[] { "Content 1", new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(5021), "Slug 1", "Title 1" });

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedAt", "Slug", "Title" },
                values: new object[] { "Content 2", new DateTime(2024, 5, 8, 10, 4, 37, 310, DateTimeKind.Utc).AddTicks(5031), "Slug 2", "Title 2" });

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
    }
}
