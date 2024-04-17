using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class RevetLastMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2588), new DateTime(2024, 4, 27, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2602), new DateTime(2024, 4, 22, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2618), new DateTime(2024, 5, 2, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2620), new DateTime(2024, 4, 27, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2621) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2624), new DateTime(2024, 5, 7, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2627), new DateTime(2024, 5, 2, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2631), new DateTime(2024, 5, 12, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2634), new DateTime(2024, 5, 7, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2635) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2637), new DateTime(2024, 5, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2640), new DateTime(2024, 5, 12, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Arbitrators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1644));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3056));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(9490));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(9248));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(9264));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6155));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3976), new DateTime(2024, 4, 17, 11, 37, 45, 894, DateTimeKind.Local).AddTicks(3989) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4103), new DateTime(2024, 4, 17, 11, 37, 45, 894, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4112), new DateTime(2024, 4, 17, 11, 37, 45, 894, DateTimeKind.Local).AddTicks(4114) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4119), new DateTime(2024, 4, 17, 11, 37, 45, 894, DateTimeKind.Local).AddTicks(4122) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5373));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5377));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5396));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8892), new DateTime(2024, 4, 22, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8898), new DateTime(2024, 4, 19, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8914), new DateTime(2024, 4, 20, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8920), new DateTime(2024, 4, 25, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8923), new DateTime(2024, 4, 22, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8925), new DateTime(2024, 4, 23, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(544), new DateTime(2024, 4, 27, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(550), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(881), new DateTime(2024, 5, 7, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(886), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4239));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4250));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 891, DateTimeKind.Utc).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8766));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 890, DateTimeKind.Utc).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3648));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 17, 9, 37, 45, 894, DateTimeKind.Utc).AddTicks(3669));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(6405), new DateTime(2024, 4, 26, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(6413), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 16, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(6731), new DateTime(2024, 5, 6, 14, 43, 8, 848, DateTimeKind.Utc).AddTicks(6737), "Monday" });

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
    }
}
