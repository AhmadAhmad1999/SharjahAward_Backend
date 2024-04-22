using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class EditTables_ContactUS_User_Arbitration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "EmailMessages",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EnglishGuidDescription",
                table: "ArbitrationProcedure",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ArabicGuidDescription",
                table: "ArbitrationProcedure",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Arbitration",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Arbitration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Arbitration",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedAt",
                table: "Arbitration",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Arbitration",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isAccepted",
                table: "Arbitration",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Arbitration",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6172), new DateTime(2024, 5, 2, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6177), "Thursday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 22, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6426), new DateTime(2024, 5, 12, 7, 49, 42, 281, DateTimeKind.Utc).AddTicks(6429), "Sunday" });

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

            migrationBuilder.CreateIndex(
                name: "IX_EmailMessages_UserId",
                table: "EmailMessages",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmailMessages_Users_UserId",
                table: "EmailMessages",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmailMessages_Users_UserId",
                table: "EmailMessages");

            migrationBuilder.DropIndex(
                name: "IX_EmailMessages_UserId",
                table: "EmailMessages");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "EmailMessages");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Arbitration");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Arbitration");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Arbitration");

            migrationBuilder.DropColumn(
                name: "LastModifiedAt",
                table: "Arbitration");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Arbitration");

            migrationBuilder.DropColumn(
                name: "isAccepted",
                table: "Arbitration");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Arbitration");

            migrationBuilder.AlterColumn<string>(
                name: "EnglishGuidDescription",
                table: "ArbitrationProcedure",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ArabicGuidDescription",
                table: "ArbitrationProcedure",
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
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6289), new DateTime(2024, 4, 28, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6296), new DateTime(2024, 4, 23, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6307) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6310), new DateTime(2024, 5, 3, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6314), new DateTime(2024, 4, 28, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6317), new DateTime(2024, 5, 8, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6320), new DateTime(2024, 5, 3, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6321) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6324), new DateTime(2024, 5, 13, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6326), new DateTime(2024, 5, 8, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6327) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6329), new DateTime(2024, 5, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6332), new DateTime(2024, 5, 13, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8899));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8818));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7043));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7048));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 17, DateTimeKind.Utc).AddTicks(4858));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 17, DateTimeKind.Utc).AddTicks(4864));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 17, DateTimeKind.Utc).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 17, DateTimeKind.Utc).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 17, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 17, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 17, DateTimeKind.Utc).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9180));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9184));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9189));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7420), new DateTime(2024, 4, 18, 16, 50, 34, 18, DateTimeKind.Local).AddTicks(7428) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7531), new DateTime(2024, 4, 18, 16, 50, 34, 18, DateTimeKind.Local).AddTicks(7534) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7539), new DateTime(2024, 4, 18, 16, 50, 34, 18, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7546), new DateTime(2024, 4, 18, 16, 50, 34, 18, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8673));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7011), new DateTime(2024, 4, 23, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7016), new DateTime(2024, 4, 20, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7029), new DateTime(2024, 4, 21, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7034), new DateTime(2024, 4, 26, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7037), new DateTime(2024, 4, 23, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7039), new DateTime(2024, 4, 24, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8715));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7859), new DateTime(2024, 4, 28, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(7865), "Sunday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8142), new DateTime(2024, 5, 8, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8146), "Wednesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7642));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7646));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(6918));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 16, DateTimeKind.Utc).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6851));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 18, 14, 50, 34, 18, DateTimeKind.Utc).AddTicks(7166));
        }
    }
}
