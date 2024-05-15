using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddSeederTo_AwardStatistic_ReferenceSource : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChairmanNotesOnInitialArbitrations_Arbitrators_ChairmanId",
                table: "ChairmanNotesOnInitialArbitrations");

            migrationBuilder.DropIndex(
                name: "IX_ChairmanNotesOnInitialArbitrations_ChairmanId",
                table: "ChairmanNotesOnInitialArbitrations");

            migrationBuilder.DropColumn(
                name: "ChairmanId",
                table: "ChairmanNotesOnInitialArbitrations");

            migrationBuilder.AddColumn<int>(
                name: "FullScore",
                table: "Arbitrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsRejectedFromArbitrationAuditStep",
                table: "Arbitrations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(2726), new DateTime(2024, 5, 25, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(2738), new DateTime(2024, 5, 20, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(2763), new DateTime(2024, 5, 30, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(2768), new DateTime(2024, 5, 25, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(2774), new DateTime(2024, 6, 4, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(2779), new DateTime(2024, 5, 30, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(2781) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(2785), new DateTime(2024, 6, 9, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(2790), new DateTime(2024, 6, 4, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(2793) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(2797), new DateTime(2024, 6, 14, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(2801), new DateTime(2024, 6, 9, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5826));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5838));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5423));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8058));

            migrationBuilder.InsertData(
                table: "AwardStatistics",
                columns: new[] { "Id", "ArabicTitle", "CreatedAt", "CreatedBy", "CycleId", "DeletedAt", "EnglishTitle", "LastModifiedAt", "LastModifiedBy", "StatisticValue", "isDeleted" },
                values: new object[,]
                {
                    { 1, "المشتركين بالجائزة خلال الدورات 1", new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(544), null, 1, null, "Award winners during training courses V1", null, null, 1000, false },
                    { 2, "المشتركين بالجائزة خلال الدورات 2", new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(554), null, 1, null, "Award winners during training courses V2", null, null, 2000, false },
                    { 3, "المشتركين بالجائزة خلال الدورات 3", new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(589), null, 1, null, "Award winners during training courses V3", null, null, 3000, false },
                    { 4, "المشتركين بالجائزة خلال الدورات 4", new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(596), null, 1, null, "Award winners during training courses V4", null, null, 4000, false },
                    { 5, "المشتركين بالجائزة خلال الدورات 5", new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(604), null, 1, null, "Award winners during training courses V5", null, null, 5000, false }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7780));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7849));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8885));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(4012), new DateTime(2024, 5, 15, 13, 26, 20, 377, DateTimeKind.Local).AddTicks(4026) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(4147), new DateTime(2024, 5, 15, 13, 26, 20, 377, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(4166), new DateTime(2024, 5, 15, 13, 26, 20, 377, DateTimeKind.Local).AddTicks(4170) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(4183), new DateTime(2024, 5, 15, 13, 26, 20, 377, DateTimeKind.Local).AddTicks(4187) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(3831));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(1879), new DateTime(2024, 5, 20, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(1886), new DateTime(2024, 5, 17, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(1900), new DateTime(2024, 5, 18, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(1907), new DateTime(2024, 5, 23, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(1913), new DateTime(2024, 5, 20, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(1916), new DateTime(2024, 5, 21, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9261));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5240));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(4507), new DateTime(2024, 5, 25, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(4517), "Saturday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(4841), new DateTime(2024, 6, 4, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(4849), "Tuesday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6905));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6979));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7008));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7167));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7250));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8677));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 374, DateTimeKind.Utc).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(6110));

            migrationBuilder.InsertData(
                table: "ReferenceSources",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "ImageUrl", "LastModifiedAt", "LastModifiedBy", "Sources", "Title", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(774), null, null, "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000", null, null, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "الدليل التفسيري لجائزة جوهرة اللغة العربية", false },
                    { 2, new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(784), null, null, "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000", null, null, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "الأدلة التفسيرية لفئة الأفراد المتميزين", false },
                    { 3, new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(790), null, null, "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000", null, null, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "الأدلة التفسيرية لفئة المؤسسات المتميزة", false },
                    { 4, new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(796), null, null, "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000", null, null, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "الأدلة التفسيرية لفئة فرق العمل  المتميزة", false },
                    { 5, new DateTime(2024, 5, 15, 10, 26, 20, 378, DateTimeKind.Utc).AddTicks(802), null, null, "https://award-shj.ae/media/hk2fyzfv/%D8%A7%D9%84%D8%B4%D9%8A%D8%AE-%D8%B3%D9%84%D8%B7%D8%A7%D9%86.jpg?anchor=center&mode=crop&width=420&height=232&rnd=133099679521200000", null, null, "https://award-shj.ae/media/jnkg2b5u/%D8%AC%D8%A7%D8%A6%D8%B2%D8%A9-%D8%AC%D9%88%D9%87%D8%B1%D8%A9-%D8%A7%D9%84%D9%84%D8%BA%D8%A9-%D8%A7%D9%84%D8%B9%D8%B1%D8%A8%D9%8A%D8%A9-30.pdf", "المصادر التوضيحية لجميع الفئات", false }
                });

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5987));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(9630));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(3067));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 15, 10, 26, 20, 377, DateTimeKind.Utc).AddTicks(3508));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AwardStatistics",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ReferenceSources",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "FullScore",
                table: "Arbitrations");

            migrationBuilder.DropColumn(
                name: "IsRejectedFromArbitrationAuditStep",
                table: "Arbitrations");

            migrationBuilder.AddColumn<int>(
                name: "ChairmanId",
                table: "ChairmanNotesOnInitialArbitrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AboutAwardPage",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3234), new DateTime(2024, 5, 24, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3245), new DateTime(2024, 5, 19, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3262), new DateTime(2024, 5, 29, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3267), new DateTime(2024, 5, 24, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3274), new DateTime(2024, 6, 3, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3278), new DateTime(2024, 5, 29, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3286), new DateTime(2024, 6, 8, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3290), new DateTime(2024, 6, 3, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Agendas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3296), new DateTime(2024, 6, 13, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3300), new DateTime(2024, 6, 8, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "ArbitrationScales",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "ArbitrationScalesCriterions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7952));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "AwardSponsors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8086));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9128));

            migrationBuilder.UpdateData(
                table: "CategoryEducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "CategoryFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3735));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Coordinators",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3760));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(155));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 527, DateTimeKind.Utc).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Cycles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6626));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6678));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4389), new DateTime(2024, 5, 14, 17, 38, 0, 526, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4528), new DateTime(2024, 5, 14, 17, 38, 0, 526, DateTimeKind.Local).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4544), new DateTime(2024, 5, 14, 17, 38, 0, 526, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "EducationCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "RelatedDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4557), new DateTime(2024, 5, 14, 17, 38, 0, 526, DateTimeKind.Local).AddTicks(4561) });

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5843));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5869));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "EducationalClasses",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5896));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.UpdateData(
                table: "EducationalEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "EducationalInstitutions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5485), new DateTime(2024, 5, 19, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5493), new DateTime(2024, 5, 16, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5508), new DateTime(2024, 5, 17, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "EndDate", "EventDate", "StartDate" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5516), new DateTime(2024, 5, 22, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5522), new DateTime(2024, 5, 19, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5525), new DateTime(2024, 5, 20, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5527) });

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9507));

            migrationBuilder.UpdateData(
                table: "ExplanatoryGuides",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9514));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9657));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "FrequentlyAskedQuestions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "GeneralFAQCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7413));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "GeneralFAQs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(6842), new DateTime(2024, 5, 24, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(6851), "Friday" });

            migrationBuilder.UpdateData(
                table: "GeneralWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DateOfWorkShop", "DayName" },
                values: new object[] { new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7196), new DateTime(2024, 6, 3, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(7202), "Monday" });

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "InstitutionCoordinators",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7094));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7172));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7177));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7279));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7289));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7311));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7321));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7327));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(7355));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8671));

            migrationBuilder.UpdateData(
                table: "OnePageText",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8700));

            migrationBuilder.UpdateData(
                table: "OurGoals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "PermissionHeaders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5308));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 523, DateTimeKind.Utc).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "RelatedAccountRequests",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "RelatedAccounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "TermsAndConditions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(9847));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "TrainingWorkshops",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(5485));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2024, 5, 14, 14, 38, 0, 526, DateTimeKind.Utc).AddTicks(3948));

            migrationBuilder.CreateIndex(
                name: "IX_ChairmanNotesOnInitialArbitrations_ChairmanId",
                table: "ChairmanNotesOnInitialArbitrations",
                column: "ChairmanId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChairmanNotesOnInitialArbitrations_Arbitrators_ChairmanId",
                table: "ChairmanNotesOnInitialArbitrations",
                column: "ChairmanId",
                principalTable: "Arbitrators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
