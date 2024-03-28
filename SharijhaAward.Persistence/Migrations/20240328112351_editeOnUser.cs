using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class editeOnUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FinalArbitrationEndDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "FinalArbitrationStartDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "InitialArbitrationEndDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "InitialArbitrationStartDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SubscriberPortalClosingDate",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfGroupCategories",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfIndividualCategories",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinalArbitrationEndDate",
                table: "Cycles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinalArbitrationStartDate",
                table: "Cycles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InitialArbitrationEndDate",
                table: "Cycles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InitialArbitrationStartDate",
                table: "Cycles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SubscriberPortalClosingDate",
                table: "Cycles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WinningScore",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "RelatedToClasses",
                table: "Categories",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "FinalArbitrationQualificationMark",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ExpectedNumberOfWinners",
                table: "Categories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                table: "Cycles",
                keyColumn: "Id",
                keyValue: new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"),
                columns: new[] { "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationEndDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { null, null, null, null, null });

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
                columns: new[] { "CreatedAt", "NumberOfGroupCategories", "NumberOfIndividualCategories" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1209), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                columns: new[] { "CreatedAt", "NumberOfGroupCategories", "NumberOfIndividualCategories" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1216), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                columns: new[] { "CreatedAt", "NumberOfGroupCategories", "NumberOfIndividualCategories" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1220), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                columns: new[] { "CreatedAt", "NumberOfGroupCategories", "NumberOfIndividualCategories" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1225), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                columns: new[] { "CreatedAt", "NumberOfGroupCategories", "NumberOfIndividualCategories" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1744), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                columns: new[] { "CreatedAt", "NumberOfGroupCategories", "NumberOfIndividualCategories" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1740), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                columns: new[] { "CreatedAt", "NumberOfGroupCategories", "NumberOfIndividualCategories" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1735), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                columns: new[] { "CreatedAt", "NumberOfGroupCategories", "NumberOfIndividualCategories" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1730), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                columns: new[] { "CreatedAt", "NumberOfGroupCategories", "NumberOfIndividualCategories" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1724), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "NumberOfGroupCategories", "NumberOfIndividualCategories" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 47, 763, DateTimeKind.Utc).AddTicks(1719), 0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfGroupCategories",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NumberOfIndividualCategories",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FinalArbitrationEndDate",
                table: "Cycles");

            migrationBuilder.DropColumn(
                name: "FinalArbitrationStartDate",
                table: "Cycles");

            migrationBuilder.DropColumn(
                name: "InitialArbitrationEndDate",
                table: "Cycles");

            migrationBuilder.DropColumn(
                name: "InitialArbitrationStartDate",
                table: "Cycles");

            migrationBuilder.DropColumn(
                name: "SubscriberPortalClosingDate",
                table: "Cycles");

            migrationBuilder.AlterColumn<int>(
                name: "WinningScore",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "RelatedToClasses",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FinalArbitrationQualificationMark",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExpectedNumberOfWinners",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinalArbitrationEndDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FinalArbitrationStartDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InitialArbitrationEndDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InitialArbitrationStartDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SubscriberPortalClosingDate",
                table: "Categories",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e5f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7676), new DateTime(2024, 4, 27, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7684), new DateTime(2024, 4, 22, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e6f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7654), new DateTime(2024, 4, 22, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7659), new DateTime(2024, 4, 17, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7664) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e7f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7282), new DateTime(2024, 4, 17, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7286), new DateTime(2024, 4, 12, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7261), new DateTime(2024, 4, 12, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7266), new DateTime(2024, 4, 7, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7216), new DateTime(2024, 4, 7, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7231), new DateTime(2024, 4, 2, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9639));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9856));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9868));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9461));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9468));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationEndDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(8380), new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(8387), new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(8391), null, new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(8395), new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationEndDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(8334), new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(8345), new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(8353), null, new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(8357), new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 350, DateTimeKind.Utc).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 350, DateTimeKind.Utc).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 350, DateTimeKind.Utc).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 350, DateTimeKind.Utc).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 350, DateTimeKind.Utc).AddTicks(5841));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 350, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 350, DateTimeKind.Utc).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(9840), new DateTime(2024, 3, 28, 13, 23, 46, 352, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(9983), new DateTime(2024, 3, 28, 13, 23, 46, 352, DateTimeKind.Local).AddTicks(9991) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(7), new DateTime(2024, 3, 28, 13, 23, 46, 353, DateTimeKind.Local).AddTicks(13) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(29), new DateTime(2024, 3, 28, 13, 23, 46, 353, DateTimeKind.Local).AddTicks(36) });

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(9663));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(4656), new DateTime(2024, 4, 2, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(4692), new DateTime(2024, 3, 30, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(4706), new DateTime(2024, 3, 31, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(4711) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(4718), new DateTime(2024, 4, 5, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(4727), new DateTime(2024, 4, 2, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(4731), new DateTime(2024, 4, 3, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(4733) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(9087));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "Time" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(7703), new DateTime(2024, 4, 7, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(7722), "11:23:46.3498068" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                columns: new[] { "CreatedAt", "DateOfWorkShop", "Time" },
                values: new object[] { new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(8126), new DateTime(2024, 4, 17, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(8139), "11:23:46.3498149" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e8f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 349, DateTimeKind.Utc).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(2239));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db17"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db18"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db19"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e74"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e75"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db20"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db21"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db22"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(9294));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2df81130-cd8f-4d2e-823b-f3e6b353db23"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 352, DateTimeKind.Utc).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e74d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e75d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e76d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e77d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e78d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 28, 11, 23, 46, 353, DateTimeKind.Utc).AddTicks(1515));
        }
    }
}
