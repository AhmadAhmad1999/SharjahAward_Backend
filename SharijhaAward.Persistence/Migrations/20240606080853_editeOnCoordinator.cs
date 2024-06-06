using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editeOnCoordinator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EducationType",
                table: "Coordinators");

            migrationBuilder.DropColumn(
                name: "Emirates",
                table: "Coordinators");

            migrationBuilder.DropColumn(
                name: "PersonalPhoto",
                table: "Coordinators");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1169), new DateTime(2024, 6, 16, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1173), new DateTime(2024, 6, 11, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1178) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1179), new DateTime(2024, 6, 21, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1181), new DateTime(2024, 6, 16, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1182) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1183), new DateTime(2024, 6, 26, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1185), new DateTime(2024, 6, 21, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1187), new DateTime(2024, 7, 1, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1189), new DateTime(2024, 6, 26, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1191), new DateTime(2024, 7, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1192), new DateTime(2024, 7, 1, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3758));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1215));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3409));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3411));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1400));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3703));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1623), new DateTime(2024, 6, 6, 11, 8, 49, 771, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1645), new DateTime(2024, 6, 6, 11, 8, 49, 771, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1648), new DateTime(2024, 6, 6, 11, 8, 49, 771, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1651), new DateTime(2024, 6, 6, 11, 8, 49, 771, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2103));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(303), new DateTime(2024, 6, 11, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(306), new DateTime(2024, 6, 8, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(313), new DateTime(2024, 6, 9, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(317), new DateTime(2024, 6, 14, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(319), new DateTime(2024, 6, 11, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(320), new DateTime(2024, 6, 12, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3460));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(800), new DateTime(2024, 6, 16, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(803), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 6, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(979), new DateTime(2024, 6, 26, 8, 8, 49, 770, DateTimeKind.Utc).AddTicks(982), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 769, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 769, DateTimeKind.Utc).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 769, DateTimeKind.Utc).AddTicks(9837));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 769, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 769, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1947));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 6, 8, 8, 49, 771, DateTimeKind.Utc).AddTicks(1475));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EducationType",
                table: "Coordinators",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Emirates",
                table: "Coordinators",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PersonalPhoto",
                table: "Coordinators",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(711), new DateTime(2024, 6, 14, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(722), new DateTime(2024, 6, 9, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(741) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(745), new DateTime(2024, 6, 19, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(748), new DateTime(2024, 6, 14, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(754), new DateTime(2024, 6, 24, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(757), new DateTime(2024, 6, 19, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(762), new DateTime(2024, 6, 29, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(768), new DateTime(2024, 6, 24, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(773), new DateTime(2024, 7, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(775), new DateTime(2024, 6, 29, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6389));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6532));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "EducationType", "Emirates", "PersonalPhoto" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1097), 0, 5, "https://backend.stg.award-shj.ae/UploadedFiles/02ef2561-b108-4b12-8a3f-6734b4e0345f.jpg" });

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "EducationType", "Emirates", "PersonalPhoto" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1106), 0, 2, "https://backend.stg.award-shj.ae/UploadedFiles/e6258b6f-5ca5-4168-bb7c-fe1f24a6e553.jpg" });

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "EducationType", "Emirates", "PersonalPhoto" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1110), 1, 1, "https://backend.stg.award-shj.ae/UploadedFiles/eecad556-2d56-4010-b10a-780f7500f693.png" });

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "EducationType", "Emirates", "PersonalPhoto" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1115), 1, 2, "https://backend.stg.award-shj.ae/UploadedFiles/eecad556-2d56-4010-b10a-780f7500f693.png" });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6796));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6809));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6814));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6826));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3706));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3575));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1608), new DateTime(2024, 6, 4, 13, 44, 33, 826, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1750), new DateTime(2024, 6, 4, 13, 44, 33, 826, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1778), new DateTime(2024, 6, 4, 13, 44, 33, 826, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1789), new DateTime(2024, 6, 4, 13, 44, 33, 826, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1502));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4355), new DateTime(2024, 6, 9, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4360), new DateTime(2024, 6, 6, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4378), new DateTime(2024, 6, 7, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4383), new DateTime(2024, 6, 12, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4386), new DateTime(2024, 6, 9, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4388), new DateTime(2024, 6, 10, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6417));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(5481), new DateTime(2024, 6, 14, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(5487), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(5924), new DateTime(2024, 6, 24, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(5927), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1935));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1943));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4445));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4457));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4479));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4540));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4591));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4000));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4047));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4055));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(3581));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 823, DateTimeKind.Utc).AddTicks(3584));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7335));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7340));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3136));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(3141));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 10, 44, 33, 826, DateTimeKind.Utc).AddTicks(1278));
        }
    }
}
