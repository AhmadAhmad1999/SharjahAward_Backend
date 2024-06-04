using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable_ExplanatoryMessages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExplanatoryMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArabicText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExplanatoryMessages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9321));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5935), new DateTime(2024, 6, 14, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5943), new DateTime(2024, 6, 9, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5962), new DateTime(2024, 6, 19, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5964), new DateTime(2024, 6, 14, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5965) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5967), new DateTime(2024, 6, 24, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5969), new DateTime(2024, 6, 19, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5972), new DateTime(2024, 6, 29, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5975), new DateTime(2024, 6, 24, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5978), new DateTime(2024, 7, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5980), new DateTime(2024, 6, 29, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4240));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4246));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4255));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(986));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9115));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9724));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8255));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6695), new DateTime(2024, 6, 4, 12, 13, 21, 685, DateTimeKind.Local).AddTicks(6707) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6812), new DateTime(2024, 6, 4, 12, 13, 21, 685, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6838), new DateTime(2024, 6, 4, 12, 13, 21, 685, DateTimeKind.Local).AddTicks(6840) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6853), new DateTime(2024, 6, 4, 12, 13, 21, 685, DateTimeKind.Local).AddTicks(6855) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7714));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2410), new DateTime(2024, 6, 9, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2415), new DateTime(2024, 6, 6, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2432), new DateTime(2024, 6, 7, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2437), new DateTime(2024, 6, 12, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2440), new DateTime(2024, 6, 9, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2442), new DateTime(2024, 6, 10, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9828));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9914));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9934));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3880));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3891));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3368), new DateTime(2024, 6, 14, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3659), new DateTime(2024, 6, 24, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6963));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8689));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8696));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8702));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8708));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9517));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(9416));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 682, DateTimeKind.Utc).AddTicks(1788));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(1238));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7819));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7823));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 686, DateTimeKind.Utc).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7469));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7473));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6413));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 9, 13, 21, 685, DateTimeKind.Utc).AddTicks(6418));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExplanatoryMessages");

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7254), new DateTime(2024, 6, 14, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7267), new DateTime(2024, 6, 9, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7287), new DateTime(2024, 6, 19, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7290), new DateTime(2024, 6, 14, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7292) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7295), new DateTime(2024, 6, 24, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7298), new DateTime(2024, 6, 19, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7303), new DateTime(2024, 6, 29, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7307), new DateTime(2024, 6, 24, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7312), new DateTime(2024, 7, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7316), new DateTime(2024, 6, 29, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3813));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3837));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3843));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1928));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1941));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2789));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7688));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3528));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3538));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3554));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1676));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(590));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8356), new DateTime(2024, 6, 4, 11, 43, 18, 725, DateTimeKind.Local).AddTicks(8366) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8521), new DateTime(2024, 6, 4, 11, 43, 18, 725, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8554), new DateTime(2024, 6, 4, 11, 43, 18, 725, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8569), new DateTime(2024, 6, 4, 11, 43, 18, 725, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9822));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9833));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9918), new DateTime(2024, 6, 9, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9926), new DateTime(2024, 6, 6, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9951), new DateTime(2024, 6, 7, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9954) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9959), new DateTime(2024, 6, 12, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9964), new DateTime(2024, 6, 9, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9967), new DateTime(2024, 6, 10, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(9969) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3085));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3101));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(1577), new DateTime(2024, 6, 14, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop" },
                values: new object[] { new DateTime(2024, 6, 4, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(1923), new DateTime(2024, 6, 24, 8, 43, 18, 722, DateTimeKind.Utc).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1163));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1187));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1242));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1256));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1261));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1273));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1285));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2510));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 721, DateTimeKind.Utc).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 726, DateTimeKind.Utc).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 6, 4, 8, 43, 18, 725, DateTimeKind.Utc).AddTicks(7921));
        }
    }
}
