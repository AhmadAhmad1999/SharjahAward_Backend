using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOnAboutPage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OurGoals",
                table: "AboutAwardPage");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "AboutAwardPage",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_AboutAwardPage",
                table: "AboutAwardPage",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "OurGoals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicGoal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishGoal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutAwardPageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OurGoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OurGoal_AboutAwardPage_AboutAwardPageId",
                        column: x => x.AboutAwardPageId,
                        principalTable: "AboutAwardPage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7783));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 278, DateTimeKind.Utc).AddTicks(7735));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5323), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5325), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5326), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5327), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5329) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5296), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5299), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5304), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5317), new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5795));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5692));

           

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 8, 14, 5, 279, DateTimeKind.Utc).AddTicks(5507));

            migrationBuilder.CreateIndex(
                name: "IX_OurGoal_AboutAwardPageId",
                table: "OurGoals",
                column: "AboutAwardPageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OurGoals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AboutAwardPage",
                table: "AboutAwardPage");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AboutAwardPage");

            migrationBuilder.AddColumn<string>(
                name: "OurGoals",
                table: "AboutAwardPage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(84));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(7961), new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(7963), new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(7965), new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(7966), new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(7934), new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(7940), new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(7946), new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(7955), new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8398));

            

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8180));
        }
    }
}
