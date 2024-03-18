using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SharijhaAward.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class addWorkshopAndAboutPage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutAwardPage",
                columns: table => new
                {
                    ArabicAboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishAboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicAboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishAboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicOurVisionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishOurVisionTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicOurVisionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishOurVisionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurVisionImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OurGoals = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GeneralWorkshops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArabicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnglishDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArabicDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumbnale = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfWorkShop = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralWorkshops", x => x.Id);
                });

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
                table: "cycles",
                keyColumn: "Id",
                keyValue: new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"),
                column: "Status",
                value: 2);

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 18, 7, 47, 1, 820, DateTimeKind.Utc).AddTicks(8180));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutAwardPage");

            migrationBuilder.DropTable(
                name: "GeneralWorkshops");

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "AttributeDataTypes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "AttributeOperations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "AttributeTableNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 2, DateTimeKind.Utc).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79b"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(135), new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(137), new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(139), new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(140), new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                columns: new[] { "CreatedAt", "FinalArbitrationEndDate", "FinalArbitrationStartDate", "InitialArbitrationStartDate", "SubscriberPortalClosingDate" },
                values: new object[] { new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(88), new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(93), new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(99), new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(126), new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("06fc4cca-fe8f-4c01-5e3f-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 3, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("1ac9755c-3c57-4659-5e3e-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 3, DateTimeKind.Utc).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("5542d87a-7f44-4163-5e3c-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 3, DateTimeKind.Utc).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "CriterionItems",
                keyColumn: "Id",
                keyValue: new Guid("fea46b75-b836-4dcc-5e3d-08dc427e4e9f"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 3, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("49b5510b-c82a-441b-45ce-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 3, DateTimeKind.Utc).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("e2476afd-f501-4461-45d0-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 3, DateTimeKind.Utc).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "Criterions",
                keyColumn: "Id",
                keyValue: new Guid("fa49f064-fc70-447b-45cf-08dc427e4e73"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 3, DateTimeKind.Utc).AddTicks(1923));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeListValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "DynamicAttributeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "DynamicAttributes",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(693));

           

            migrationBuilder.UpdateData(
                table: "ProvidedForms",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "cycles",
                keyColumn: "Id",
                keyValue: new Guid("784454bd-2d6c-49ae-9e8a-1932bd15aac1"),
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: new Guid("81a2c75e-c71c-4213-a372-7626db57e79d"),
                column: "CreatedAt",
                value: new DateTime(2024, 3, 14, 13, 4, 38, 4, DateTimeKind.Utc).AddTicks(476));
        }
    }
}
