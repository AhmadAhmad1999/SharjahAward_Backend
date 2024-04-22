using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddTable_Arbitrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arbitration_Arbitrators_ArbitratorId",
                table: "Arbitration");

            migrationBuilder.DropForeignKey(
                name: "FK_Arbitration_ProvidedForms_ProvidedFormId",
                table: "Arbitration");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Arbitration",
                table: "Arbitration");

            migrationBuilder.RenameTable(
                name: "Arbitration",
                newName: "Arbitrations");

            migrationBuilder.RenameIndex(
                name: "IX_Arbitration_ProvidedFormId",
                table: "Arbitrations",
                newName: "IX_Arbitrations_ProvidedFormId");

            migrationBuilder.RenameIndex(
                name: "IX_Arbitration_ArbitratorId",
                table: "Arbitrations",
                newName: "IX_Arbitrations_ArbitratorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arbitrations",
                table: "Arbitrations",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitrations_Arbitrators_ArbitratorId",
                table: "Arbitrations",
                column: "ArbitratorId",
                principalTable: "Arbitrators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitrations_ProvidedForms_ProvidedFormId",
                table: "Arbitrations",
                column: "ProvidedFormId",
                principalTable: "ProvidedForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arbitrations_Arbitrators_ArbitratorId",
                table: "Arbitrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Arbitrations_ProvidedForms_ProvidedFormId",
                table: "Arbitrations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Arbitrations",
                table: "Arbitrations");

            migrationBuilder.RenameTable(
                name: "Arbitrations",
                newName: "Arbitration");

            migrationBuilder.RenameIndex(
                name: "IX_Arbitrations_ProvidedFormId",
                table: "Arbitration",
                newName: "IX_Arbitration_ProvidedFormId");

            migrationBuilder.RenameIndex(
                name: "IX_Arbitrations_ArbitratorId",
                table: "Arbitration",
                newName: "IX_Arbitration_ArbitratorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arbitration",
                table: "Arbitration",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(4853), new DateTime(2024, 5, 2, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(4865), new DateTime(2024, 4, 27, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(4876) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(4879), new DateTime(2024, 5, 7, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(4881), new DateTime(2024, 5, 2, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(4883) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(4885), new DateTime(2024, 5, 12, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(4887), new DateTime(2024, 5, 7, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(4889) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(4891), new DateTime(2024, 5, 17, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(4893), new DateTime(2024, 5, 12, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(4895) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(4897), new DateTime(2024, 5, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(4900), new DateTime(2024, 5, 17, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7081));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7205));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6990));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 282, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 282, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 282, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 282, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 282, DateTimeKind.Utc).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 282, DateTimeKind.Utc).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 282, DateTimeKind.Utc).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7671));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(6031), new DateTime(2024, 4, 22, 9, 49, 42, 283, DateTimeKind.Local).AddTicks(6042) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(6149), new DateTime(2024, 4, 22, 9, 49, 42, 283, DateTimeKind.Local).AddTicks(6152) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(6158), new DateTime(2024, 4, 22, 9, 49, 42, 283, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(6165), new DateTime(2024, 4, 22, 9, 49, 42, 283, DateTimeKind.Local).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(4830), new DateTime(2024, 4, 27, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(4835), new DateTime(2024, 4, 24, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(4846), new DateTime(2024, 4, 25, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(4848) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(4851), new DateTime(2024, 4, 30, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(4854), new DateTime(2024, 4, 27, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(4855), new DateTime(2024, 4, 28, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(4857) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6172), new DateTime(2024, 5, 2, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6426), new DateTime(2024, 5, 12, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6729));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5365));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7009));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 22, 7, 49, 42, 283, DateTimeKind.Utc).AddTicks(5714));

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitration_Arbitrators_ArbitratorId",
                table: "Arbitration",
                column: "ArbitratorId",
                principalTable: "Arbitrators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitration_ProvidedForms_ProvidedFormId",
                table: "Arbitration",
                column: "ProvidedFormId",
                principalTable: "ProvidedForms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
